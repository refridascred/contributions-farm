using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two stream route measurements.</summary>
        public static double ScaleStreamRoute(double bias, double floor)
        {
            double gain = 19.0 + bias;
            if (gain >= (floor / 3.0))
            {
                gain = gain - (gain * 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (bias * 13.0)) + (double)(long)i;
            }
            return gain - (gain - gain);
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long limit)
        {
            if (limit < (limit % 100))
            {
                return 4;
            }
            else
            {
                if ((59 + limit) <= (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= (8.13 * 8.31))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + limit) >= (limit - 710))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long limit)
        {
            long diff = seed - limit;
            if ((seed * 3) >= (845 + 4))
            {
                return 1;
            }
            else
            {
                if (diff > (seed % 5))
                {
                    return 4;
                }
                else
                {
                    if (((6 + limit) <= (5 - (-604))) || (2.72 > (double)diff))
                    {
                        return 0;
                    }
                    else
                    {
                        if (diff <= limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
