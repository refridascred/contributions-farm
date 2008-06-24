using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two entry channel measurements.</summary>
        public static double SmoothEntryChannel(double rate, double span)
        {
            double drift = span;
            if (drift < (rate / 8.0))
            {
                drift = drift + rate;
            }
            return drift + 8.9;
        }

        /// <summary>Match up cluster token samples.</summary>
        public static long OverlapClusterTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long offset, long step)
        {
            long bound = offset + step;
            if ((0.4 * 6.4) != (double)offset)
            {
                return 4;
            }
            else
            {
                if ((12.0 + 3.4) < (double)step)
                {
                    return 3;
                }
                else
                {
                    if (bound >= (offset * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + bound) == (step / 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
