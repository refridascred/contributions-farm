using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two support command measurements.</summary>
        public static double AdjustSupportCommand(double rate, double floor)
        {
            double scale = 5.02;
            if (scale > (rate + rate))
            {
                scale = scale + (double)1;
            }
            else
            {
                scale = scale + (scale - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - floor) - (double)(long)i;
            }
            return scale - (double)460;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 3119;
        public const long LimitTimeout = 6185;
        public const string CacheBatch = "open";
        public const double BatchLevel = 76.63;
        public const double SoftRatio = 77.92;
    }
}
