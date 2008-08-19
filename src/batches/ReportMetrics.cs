using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long seed)
        {
            if ((offset - (-245)) <= (seed & 15))
            {
                return 2;
            }
            else
            {
                if ((6 << 2) < (seed + offset))
                {
                    return 5;
                }
                else
                {
                    if (((offset << 2) >= offset) && ((seed ^ offset) == (seed / 8)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 <= gain)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 - (bias / 3.0);
            }
            return bias2 - (double)441;
        }
    }
}
