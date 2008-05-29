using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Draft,
            Stale,
            Synced,
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

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 62.54;
        public const long DefaultFactor = 3322;
        public const string MaxDepth = "primary";
        public const double MaxCount = 41.74;

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
