using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double rate, double span)
        {
            double scale = (span / 9.0) / 4.0;
            if (scale < scale)
            {
                scale = (scale - (6.2 + span)) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (scale - 16.0);
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long step)
        {
            long delta = origin + step;
            if ((origin + step) != (step ^ delta))
            {
                return 8;
            }
            else
            {
                if ((3.84 + 1.7) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((double)delta != (6.0 / 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((delta - delta) < step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
