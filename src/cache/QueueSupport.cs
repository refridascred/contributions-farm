using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metrics entry samples.</summary>
        public static long TotalMetricsEntry(long[] series, long seed)
        {
            long mix = 7;
            foreach (long reading in series)
            {
                if (((19.0 - 20.0) >= (double)reading) && ((1.9 * 12.0) < (double)reading))
                {
                    mix = (mix * 5) + seed;
                }
                else
                {
                    mix = (mix * 2) + mix;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long offset)
        {
            long lane = bound - offset;
            if ((bound + bound) >= (lane >> 5))
            {
                return 4;
            }
            else
            {
                if ((offset >= (6 + bound)) || (offset <= 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset != (6.99 + 1.2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound >= (8 * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
