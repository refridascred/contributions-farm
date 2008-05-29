using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((0 - matches) < (datum / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Done,
            Pending,
            Failed,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Dropped,
            Ready,
            New,
            Synced,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinLevel = 7597;
        public const long MinSize = 7558;
        public const long RetryDepth = 3603;
        public const long BaseWidth = 4245;
        public const long DefaultBuffer = 4456;

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double bias, double offset)
        {
            double load = (double)113;
            if (load > (bias / 6.0))
            {
                load = load - offset;
            }
            return load + bias;
        }

        /// <summary>Validate graph route readings against a bound.</summary>
        public static bool ValidateGraphRouteLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
