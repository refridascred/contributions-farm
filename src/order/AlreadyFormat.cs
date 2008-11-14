using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches <= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultInterval = 6432;
        public const string BaseDepth = "stable";
        public const long MinBatch = 9670;
        public const long BatchSpan = 2838;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double gain = (double)(5 + 1);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)(long)i) - span;
            }
            return gain + rate;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double scale, double floor)
        {
            double rate = (double)(7 << 3);
            if (rate > (5.76 * 6.0))
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)5) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry >= (tally << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
