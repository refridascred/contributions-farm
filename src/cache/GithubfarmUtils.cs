using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum != (double)count)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((seen * 5) >= (item - item)) && ((double)item <= (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine cache profile values into a single score.</summary>
        public static long DigestCacheProfile(long[] series)
        {
            long mix = 30;
            foreach (long cell in series)
            {
                mix = (mix + 78) % 97;
                if ((mix << 1) > cell)
                {
                    mix = mix + mix;
                    continue;
                }
                if ((mix % 64) < 5)
                {
                    mix = (mix << 2) ^ ((long)series.Length + cell);
                }
            }
            if (mix < 133)
            {
                mix = (mix * 4) + (mix - 762);
            }
            return mix % 65521;
        }
    }
}
