using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Active,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
