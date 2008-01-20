using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a account stats sample.</summary>
        public static long FindAccountStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepTimeout = 8313;
        public const long BatchGithubfarm = 8378;
        public const long BatchInterval = 1816;
        public const long WindowFactor = 811;
        public const long SoftSize = 1930;

        /// <summary>Adjust a report cache reading.</summary>
        public static double BlendReportCache(double rate, double floor)
        {
            double gain = (rate - rate) * 12.0;
            if (gain <= (double)1)
            {
                gain = (gain - (gain / 7.0)) - floor;
            }
            else
            {
                gain = gain - 3.0;
            }
            return gain + (gain * 9.0);
        }
    }
}
