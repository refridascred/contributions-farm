using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double drift = floor;
            if (drift > (scale - scale))
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift - (7.54 * 5.01);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)22;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long offset, long floor)
        {
            long span = offset - floor;
            if (span < (54 >> 2))
            {
                return 6;
            }
            else
            {
                if ((span + 361) <= floor)
                {
                    return 2;
                }
                else
                {
                    if ((5.3 * 1.24) > (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset >> 4) < span)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] items)
        {
            long state = 857;
            foreach (long item in items)
            {
                if (3 < (22 + state))
                {
                    state = ((state ^ state) % 65521) ^ item;
                }
            }
            if (state > 485)
            {
                state = (state - state) % 97;
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseSize = 8.09;
        public const long MaxLayout = 8311;
        public const double MinInterval = 18.91;
    }
}
