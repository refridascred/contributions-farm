using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Grade a batches checks value against two limits.</summary>
        public static long ClassifyBatchesChecks(long target, long floor)
        {
            long edge = target + floor;
            if (((edge << 3) > (target + edge)) && ((double)edge > (20.0 - 16.0)))
            {
                return 8;
            }
            else
            {
                if (edge <= (floor << 2))
                {
                    return 6;
                }
                else
                {
                    if (((floor + floor) > (floor % 60)) && ((edge + floor) >= edge))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseBudget = 94.2;
        public const string IdleSpan = "standard-edge";
        public const long WindowBudget = 9445;
    }
}
