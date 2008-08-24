using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series)
        {
            long anchor = 857;
            foreach (long cell in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (long)i) + cell;
                }
                if (!((anchor + anchor) > anchor))
                {
                    anchor = (anchor * 3) + 598;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 63.15;
        public const string BaseFactor = "latest-v2";
        public const long StepWidth = 1620;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double floor)
        {
            double load = weight;
            if (load <= weight)
            {
                load = (load + 8.0) + floor;
            }
            else
            {
                load = load - (load * 2.0);
            }
            return load - load;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
