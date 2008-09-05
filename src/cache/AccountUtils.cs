using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next commits metric value.</summary>
        public static double ProjectCommitsMetric(double bias, double floor)
        {
            double mean = floor;
            if (mean > floor)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (6.61 / 2.0);
            }
            return mean - bias;
        }

        /// <summary>Derive the next buffer command value from a seed.</summary>
        public static long DeriveBufferCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score >= (double)bound)
                {
                    score = score - (long)i;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
