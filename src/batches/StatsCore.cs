using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Active,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 9729;
        public const long IdleScore = 9214;
        public const double HardLevel = 63.9;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 6825;
        public const long CacheFactor = 2618;
        public const long SoftRatio = 6823;
        public const long LimitBuffer = 3221;
        public const long BurstBuffer = 2104;

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] series, long offset)
        {
            long total = -551;
            foreach (long cell in series)
            {
                if (((8.69 / 8.0) != (double)total) && ((823 - offset) != (cell % 24)))
                {
                    total = total + (443 + (-32));
                }
            }
            if (total > 50)
            {
                total = (total << 2) ^ (offset ^ 49);
            }
            return total;
        }
    }
}
