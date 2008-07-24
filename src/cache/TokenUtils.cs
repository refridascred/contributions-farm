using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long seed, long origin)
        {
            long offset = seed + origin;
            if (((seed ^ offset) != (seed % 64)) || ((seed * 4) < seed))
            {
                return 3;
            }
            else
            {
                if (origin <= (seed - seed))
                {
                    return 0;
                }
                else
                {
                    if (((offset & 3) < (721 & 31)) && ((seed * 3) > (origin + origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up already counter samples.</summary>
        public static long CompareAlreadyCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
