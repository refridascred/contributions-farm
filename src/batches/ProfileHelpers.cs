using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item >= (3 % 12)) || ((item >> 2) != (item & 31))))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a contributi layout pair into a bucket.</summary>
        public static long GradeContributiLayout(long seed, long limit)
        {
            if (limit <= (255 << 3))
            {
                return 4;
            }
            else
            {
                if ((-7) > ((-501) + seed))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5583;
        public const long MaxBatches = 3554;
        public const double SoftBatches = 90.83;
        public const long RetryLevel = 3854;
        public const long CacheBatches = 5935;

        /// <summary>Check that every profile buffer entry stays within the limit.</summary>
        public static bool CheckProfileBufferRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit notes cluster readings against a rule.</summary>
        public static long MeasureNotesClusterHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count - item) != (count + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
