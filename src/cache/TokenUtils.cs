using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long bound, long floor)
        {
            long delta = bound - floor;
            if ((delta % 12) > floor)
            {
                return 6;
            }
            else
            {
                if (((double)delta <= (double)floor) && ((floor >> 5) <= (58 << 2)))
                {
                    return 5;
                }
                else
                {
                    if (delta > (bound << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Draft,
            Synced,
            Queued,
        }
    }
}
