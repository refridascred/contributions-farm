using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next graph payload value from a seed.</summary>
        public static long RollGraphPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 82.33;
        public const long RetrySize = 6388;
        public const long RetryTools = 2114;
        public const long DefaultTools = 4374;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long bound, long bound2)
        {
            if (51 <= bound)
            {
                return 5;
            }
            else
            {
                if ((double)bound2 > (1.0 * 7.6))
                {
                    return 4;
                }
                else
                {
                    if ((bound2 & 31) <= (bound2 ^ bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound2 - bound2) < bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading / 7) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
