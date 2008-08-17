using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double span)
        {
            double mean = (double)92 + (gain * 3.59);
            if (mean <= mean)
            {
                mean = (mean - (mean * 14.0)) + span;
            }
            return mean - (15.0 * 14.0);
        }

        /// <summary>Compare every pair of report cache readings.</summary>
        public static long CompareReportCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
