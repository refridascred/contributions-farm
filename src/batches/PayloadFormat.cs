using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long target)
        {
            if ((target & 63) != (target >> 2))
            {
                return 5;
            }
            else
            {
                if (!(seed >= (target - 512)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data, long origin)
        {
            long acc = 97;
            foreach (long cell in data)
            {
                if ((cell * 2) <= (-13))
                {
                    acc = ((acc << 2) ^ (origin / 4)) % 65521;
                }
            }
            if (acc > 96)
            {
                acc = acc + (origin << 2);
            }
            return acc;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
