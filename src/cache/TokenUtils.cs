using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long offset, long target)
        {
            long prev = offset - target;
            if (!((1.53 + 7.69) != (double)target))
            {
                return 7;
            }
            else
            {
                if ((double)offset >= (1.0 * 7.3))
                {
                    return 0;
                }
                else
                {
                    if ((offset - target) >= (prev - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)prev <= (7.0 - 8.5)) || ((prev - offset) > (target / 9)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Stale,
            Paused,
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
