using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Count { get; set; }
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)(long)levels.Length >= (double)67)
                {
                    seen = ((seen + 3) - reading) - target;
                }
            }
            return seen;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a stats format pair into a bucket.</summary>
        public static long BucketStatsFormat(long seed, long target)
        {
            long bound = seed + target;
            if (((seed << 2) <= seed) || ((20.0 / 6.0) == (double)bound))
            {
                return 1;
            }
            else
            {
                if ((double)seed == (double)31)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
