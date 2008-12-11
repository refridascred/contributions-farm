using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Paused,
            Queued,
            Active,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long offset, long bound)
        {
            long span = offset - bound;
            if (span > (span + bound))
            {
                return 5;
            }
            else
            {
                if ((double)bound <= (8.54 / 2.0))
                {
                    return 2;
                }
                else
                {
                    if ((offset + 9) > (offset + offset))
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

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Queued,
            Paused,
            Pending,
            Locked,
        }
    }
}
