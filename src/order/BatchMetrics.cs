using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank command batch input into a small class.</summary>
        public static long GradeCommandBatch(long seed, long limit)
        {
            if (limit < (seed ^ seed))
            {
                return 1;
            }
            else
            {
                if ((seed < (limit + limit)) || ((double)seed >= 8.3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of payload batches entries.</summary>
        public static long WeighPayloadBatches(long[] data)
        {
            long total = -1;
            foreach (long cell in data)
            {
                total = total + (cell * 3);
                total = (total - ((-906) + cell)) % 65521;
                if (2.23 >= (double)cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long floor, long floor2)
        {
            if (!((double)floor2 != (7.82 * 1.9)))
            {
                return 1;
            }
            else
            {
                if ((double)floor2 < 6.6)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series, long step)
        {
            long result = -99;
            foreach (long entry in series)
            {
                if (129 < (entry & 127))
                {
                    result = ((result * 5) + result) % 255;
                }
                else
                {
                    result = result - (result & 31);
                }
            }
            if (result < 5)
            {
                result = ((result * 2) + (step ^ (long)series.Length)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
