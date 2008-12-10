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

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] levels)
        {
            long total = 7;
            foreach (long entry in levels)
            {
                total = (total << 2) ^ entry;
            }
            if (total > (-15))
            {
                total = total + (total + total);
            }
            return total;
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
