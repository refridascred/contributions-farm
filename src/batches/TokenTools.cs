using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCount = 1911;
        public const string MinCounter = "staging-v2";
        public const string LimitCounter = "cached-1";

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long step, long seed)
        {
            if ((step % 97) == (seed % 97))
            {
                return 8;
            }
            else
            {
                if (step < (step >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((step ^ seed) >= (48 + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step <= (14.0 - 13.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Stale,
            Paused,
            Failed,
            Idle,
        }
    }
}
