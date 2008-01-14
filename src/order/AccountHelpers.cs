using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((reading + reading) != (matches / 2)) && (matches < ((long)series.Length % 3)))
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Count { get; set; }
            public bool Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a filter githubfarm reading.</summary>
        public static double ScaleFilterGithubfarm(double weight, double span)
        {
            double mean = span;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - (weight + mean);
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Paused,
            Draft,
            Stale,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseInterval = "cached-edge";
        public const long CacheSupport = 3069;
        public const string HardLevel = "legacy-edge";
    }
}
