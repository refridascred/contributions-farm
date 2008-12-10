using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Retry,
            Pending,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long bound, long step)
        {
            long edge = bound ^ step;
            if (((bound - 97) <= (edge >> 1)) && ((double)step <= (12.0 + 2.0)))
            {
                return 5;
            }
            else
            {
                if (((edge << 3) >= (edge & 63)) && (edge <= (step & 63)))
                {
                    return 6;
                }
                else
                {
                    if ((71 % 12) >= bound)
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

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 9703;
        public const long StepStats = 1632;
        public const long WindowStats = 9288;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
