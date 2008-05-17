using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Grade a order already value against two limits.</summary>
        public static long ClassifyOrderAlready(long target, long seed)
        {
            long edge = target - seed;
            if (((4.7 * 6.55) == (double)seed) || ((target - seed) != (target + edge)))
            {
                return 1;
            }
            else
            {
                if ((target >> 1) < seed)
                {
                    return 5;
                }
                else
                {
                    if (5 <= (target - target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((edge - target) < (1 * 4)) || ((11.0 * 5.7) > (19.0 - 16.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseCount = 67.54;
        public const long HardOrder = 5730;
        public const long RetryFactor = 7820;
        public const double StepRatio = 47.71;
        public const long MaxOrder = 4330;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Stale,
            Queued,
            Draft,
        }
    }
}
