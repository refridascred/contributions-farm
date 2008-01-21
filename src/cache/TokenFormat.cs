using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Active,
            Draft,
            New,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long target, long seed)
        {
            long cur = target + seed;
            if (((double)cur == (4.53 * 9.0)) && ((394 << 1) <= (target + target)))
            {
                return 8;
            }
            else
            {
                if ((seed - cur) < target)
                {
                    return 7;
                }
                else
                {
                    if (!((seed >> 1) > (target << 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6.34 - 1.56) <= (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
