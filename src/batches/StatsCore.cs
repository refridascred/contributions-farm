using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] items)
        {
            long anchor = 97;
            foreach (long cell in items)
            {
                if (!(cell >= (anchor + anchor)))
                {
                    anchor = (anchor - (anchor << 3)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitBudget = 15.0;
        public const long RetryGithubfarm = 8567;
        public const long HardGithubfarm = 2358;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long limit, long bound)
        {
            if (9 <= bound)
            {
                return 8;
            }
            else
            {
                if ((-1) <= limit)
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitFactor = "open";
        public const string DefaultTimeout = "fallback-edge";
        public const long WindowCommand = 6979;
        public const double DefaultCommand = 56.24;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Queued,
            Pending,
            Ready,
            Locked,
        }
    }
}
