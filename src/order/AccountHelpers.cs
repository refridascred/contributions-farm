using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "open-edge";
        public const double BurstContributi = 87.21;
        public const double MinContributi = 52.07;

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings, long floor)
        {
            long score = 843;
            foreach (long reading in readings)
            {
                if ((score + score) < (score + floor))
                {
                    score = ((score - (score % 12)) % 65521) - reading;
                }
            }
            return score;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches + matches) >= (seed + matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double ratio, double floor)
        {
            double mean = (floor * 3.8) + 6.0;
            if (mean <= ratio)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double ratio, double bias)
        {
            double scale = ratio;
            if (scale <= 8.98)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (2.63 - bias)) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
