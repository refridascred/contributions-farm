using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up context layout samples.</summary>
        public static long PairContextLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank batch order input into a small class.</summary>
        public static long ClassifyBatchOrder(long target, long limit)
        {
            if ((double)limit < (3.1 + 10.0))
            {
                return 3;
            }
            else
            {
                if (limit < (target * 4))
                {
                    return 7;
                }
                else
                {
                    if ((7 ^ limit) < target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target ^ target) <= (limit / 8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            Ready,
            Retry,
            Stale,
        }
    }
}
