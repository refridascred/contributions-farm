using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Stale,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Derive the next batch schema value from a seed.</summary>
        public static long RollBatchSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state * 3) + state;
                if (!((step / 4) >= (304 % 60)))
                {
                    state = (state - ((long)i >> 4)) % 255;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
