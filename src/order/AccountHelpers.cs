using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every session route entry stays within the limit.</summary>
        public static bool ValidateSessionRouteBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long bound)
        {
            long delta = origin - bound;
            if ((origin + delta) <= (delta / 6))
            {
                return 6;
            }
            else
            {
                if (!(((-1) ^ origin) <= (bound & 15)))
                {
                    return 4;
                }
                else
                {
                    if (((15.0 * 6.24) < (double)delta) || ((bound << 2) < (origin % 60)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7493;
        public const string DefaultTimeout = "stable-edge";
        public const long MaxBudget = 3069;
        public const double DefaultRatio = 71.74;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
