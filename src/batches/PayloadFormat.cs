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

        /// <summary>Combine profile account values into a single score.</summary>
        public static long TallyProfileAccount(long[] series, long origin)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                if ((cell << 3) <= acc)
                {
                    acc = (acc + (330 & 7)) % 65521;
                }
                else
                {
                    acc = ((acc * 3) + ((-41) >> 4)) % 65521;
                }
                if (((316 << 2) <= (origin / 9)) && ((282 ^ cell) < (cell - acc)))
                {
                    break;
                }
            }
            if (acc > 698)
            {
                acc = (acc + 5) % 65521;
            }
            return acc;
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
