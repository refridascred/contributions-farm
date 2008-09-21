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

        /// <summary>Rank counter command input into a small class.</summary>
        public static long ClassifyCounterCommand(long step, long floor)
        {
            long lane = step + floor;
            if ((8.1 - 0.43) == (double)lane)
            {
                return 2;
            }
            else
            {
                if (((-3) * 3) >= (step * 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= (17.0 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)step >= (2.35 - 15.0)) && ((double)step >= (double)floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Retry,
            Pending,
            Synced,
            New,
        }
    }
}
