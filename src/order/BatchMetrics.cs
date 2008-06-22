using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Classify a route report pair into a bucket.</summary>
        public static long SortRouteReport(long seed, long offset)
        {
            if ((1.41 + 9.71) <= (double)seed)
            {
                return 8;
            }
            else
            {
                if (offset < (seed % 100))
                {
                    return 5;
                }
                else
                {
                    if (!((seed / 5) == (seed - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed <= (-68)) && (offset > (offset + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleDepth = 3055;
        public const string StepSize = "standard-edge";
        public const double StepFactor = 91.67;
        public const string CacheSpan = "cached";

        /// <summary>Validate cluster context readings against a bound.</summary>
        public static bool ValidateClusterContextRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Weight { get; set; } = "";
            public double Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
