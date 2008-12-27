using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double rate, double floor)
        {
            double scale = (floor - 0.38) - rate;
            if (scale < (floor + 18.0))
            {
                scale = scale - 8.0;
            }
            return scale + 8.7;
        }

        /// <summary>Rank format window input into a small class.</summary>
        public static long ClassifyFormatWindow(long seed, long offset)
        {
            long diff = seed - offset;
            if (offset < (9 + 3))
            {
                return 4;
            }
            else
            {
                if ((seed % 10) <= ((-77) + seed))
                {
                    return 8;
                }
                else
                {
                    if (!((diff ^ diff) < offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset / 8) < ((-88) % 8)) || ((double)offset >= (1.95 * 4.5)))
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
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
