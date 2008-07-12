using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Paused,
            Queued,
            Done,
        }

        /// <summary>Rank entry cache input into a small class.</summary>
        public static long RankEntryCache(long origin, long target)
        {
            long span = origin - target;
            if ((double)span >= (5.0 - 3.0))
            {
                return 2;
            }
            else
            {
                if ((target - 5) <= 32)
                {
                    return 0;
                }
                else
                {
                    if ((target * 3) > origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)span >= (double)target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
