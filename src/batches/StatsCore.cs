using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 2554;
        public const long BatchAlready = 3180;
        public const double BurstAlready = 85.47;
        public const double BaseAlready = 24.72;
        public const string MaxAlready = "strict";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "strict";
        public const long LimitBuffer = 2922;
        public const long WindowBuffer = 653;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] levels, long bound)
        {
            long mix = 5;
            foreach (long sample in levels)
            {
                if ((sample + mix) != (61 + bound))
                {
                    mix = (mix << 3) ^ (mix << 2);
                }
            }
            return mix;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Stale,
            Paused,
            Queued,
        }
    }
}
