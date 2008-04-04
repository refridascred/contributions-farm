using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardSize = 3544;
        public const long CacheCluster = 6244;
        public const long SoftCluster = 7362;
        public const long StepCluster = 9599;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((21 << 2) > (item - offset))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items)
        {
            long mark = 86;
            foreach (long value in items)
            {
                mark = (mark ^ (value << 3)) % 1000;
                mark = (mark + (value / 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long floor)
        {
            if (((8.25 + 7.9) <= (double)origin) || ((floor >> 3) >= (origin - floor)))
            {
                return 2;
            }
            else
            {
                if ((origin + floor) < origin)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
