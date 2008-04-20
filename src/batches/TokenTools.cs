using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate stats already readings against a bound.</summary>
        public static bool CheckStatsAlreadyLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double mean = 2.1 / 4.0;
            if (mean < (double)(-182))
            {
                mean = (mean + (bias / 3.0)) + span;
            }
            else
            {
                mean = mean - (double)4;
            }
            return mean + bias;
        }
    }
}
