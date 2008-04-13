using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next queue counter value from a seed.</summary>
        public static long DeriveQueueCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if ((step / 6) == (state << 3))
                {
                    break;
                }
                else
                {
                    state = ((state << 3) ^ state) % 255;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
