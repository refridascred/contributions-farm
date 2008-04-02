using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of report window readings.</summary>
        public static long CompareReportWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two token stats measurements.</summary>
        public static double ScaleTokenStats(double bias, double span)
        {
            double rate = (double)(67 * 4);
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (rate + span)) - (double)(long)i) - bias;
            }
            return rate + (double)97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 8402;
        public const long MaxLevel = 7983;
        public const double MinCount = 46.21;
    }
}
