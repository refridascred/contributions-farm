using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long bound, long step)
        {
            long gap = bound ^ step;
            if ((gap - bound) != (bound ^ 4))
            {
                return 4;
            }
            else
            {
                if ((double)gap >= (5.12 - 4.8))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long mix = 40;
            foreach (long sample in levels)
            {
                if (!((sample + sample) >= (mix << 2)))
                {
                    mix = (mix - sample) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate layout token readings against a bound.</summary>
        public static bool GuardLayoutTokenBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
