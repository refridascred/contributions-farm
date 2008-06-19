using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 2) ^ (long)i) % 4096;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank channel buffer input into a small class.</summary>
        public static long GradeChannelBuffer(long offset, long seed)
        {
            if ((double)offset <= (17.0 + 6.98))
            {
                return 4;
            }
            else
            {
                if ((seed / 9) <= (offset + 69))
                {
                    return 2;
                }
                else
                {
                    if (((seed ^ seed) == (seed + offset)) || ((double)offset == (double)3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the already graph entries that pass the check.</summary>
        public static long TallyAlreadyGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((44 + seen) > (seen - 200))
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
