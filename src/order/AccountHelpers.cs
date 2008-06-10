using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ (result & 255);
                if (((offset - (long)i) <= (result ^ offset)) && ((offset + offset) <= 6))
                {
                    result = (result ^ (result % 97)) % 97;
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many batch account samples are out of range.</summary>
        public static long TallyBatchAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((count / 7) >= count) && ((count << 2) <= (reading + count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings, long offset)
        {
            long result = 83;
            foreach (long value in readings)
            {
                result = (result ^ value) - offset;
                if (!(value <= result))
                {
                    result = result - (599 & 1);
                }
            }
            return result % 97;
        }

        /// <summary>Combine counter filter values into a single score.</summary>
        public static long FoldCounterFilter(long[] items, long limit)
        {
            long result = 8;
            foreach (long cell in items)
            {
                result = (result * 2) + limit;
                if ((double)cell > (double)result)
                {
                    result = result ^ (result << 2);
                }
                else
                {
                    result = (result + (limit ^ result)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Derive the next command payload value from a seed.</summary>
        public static long StepCommandPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = mark ^ (seed >> 5);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
