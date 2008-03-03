using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long origin, long limit)
        {
            if (!((double)origin <= (double)limit))
            {
                return 0;
            }
            else
            {
                if ((limit + origin) != (limit + limit))
                {
                    return 7;
                }
                else
                {
                    if (((2.0 * 16.0) < (double)origin) && ((double)limit <= (3.3 - 4.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin * 4) == (limit >> 1)) || ((origin - origin) > (limit % 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two report already measurements.</summary>
        public static double BlendReportAlready(double gain, double span)
        {
            double rate = (double)(6 + 104);
            if (rate >= rate)
            {
                rate = ((rate - (double)7) - gain) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate * 8.5)) + (double)(long)i;
            }
            return rate - (2.0 - rate);
        }
    }
}
