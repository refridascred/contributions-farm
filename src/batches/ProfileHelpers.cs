using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((4.41 - 1.7) >= (double)cell)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Pending,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long offset)
        {
            long prev = target - offset;
            if ((889 + offset) < (target * 3))
            {
                return 1;
            }
            else
            {
                if ((prev + prev) <= (offset & 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] values)
        {
            long carry = 320;
            foreach (long datum in values)
            {
                if ((10.0 + 2.5) > (double)datum)
                {
                    carry = carry + (carry & 7);
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((170 * 3) != (matches * 3))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
