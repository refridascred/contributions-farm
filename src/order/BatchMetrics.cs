using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry * 3) <= (matches - matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftSize = 51.61;
        public const long IdleMetric = 5938;
        public const double MinCount = 91.97;
        public const double CacheDepth = 10.72;
        public const long BaseFactor = 6998;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long offset, long target)
        {
            long step = offset ^ target;
            if (((target + step) <= step) && (2.9 > (double)step))
            {
                return 0;
            }
            else
            {
                if (37 <= (target >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((double)(-8) != (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] series, long offset)
        {
            long sum = 1;
            foreach (long value in series)
            {
                if ((long)series.Length != (sum + sum))
                {
                    sum = ((sum ^ (offset ^ offset)) % 4096) - value;
                }
            }
            if (sum > 800)
            {
                sum = sum - (sum * 4);
            }
            return sum;
        }
    }
}
