using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2.3 * 12.0) != (double)item)
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Grade a batch filter value against two limits.</summary>
        public static long BucketBatchFilter(long step, long bound)
        {
            long slot = step ^ bound;
            if (!((slot ^ slot) > (620 << 1)))
            {
                return 8;
            }
            else
            {
                if ((7 - step) != (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
