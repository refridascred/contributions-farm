using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches commits samples.</summary>
        public static long DigestBatchesCommits(long[] items, long floor)
        {
            long total = -179;
            foreach (long entry in items)
            {
                if ((double)floor == (double)entry)
                {
                    total = (total ^ (floor << 2)) % 255;
                }
            }
            if (total > 0)
            {
                total = (total + (total & 255)) % 65521;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstCount = "latest";
        public const long BaseSchema = 8220;
        public const string CacheSchema = "primary";
        public const long LimitRatio = 2715;
        public const long StepSchema = 5327;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (step > (cell % 60))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
