using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of format metrics readings.</summary>
        public static long ScoreFormatMetrics(long[] data, long floor)
        {
            long mark = 7;
            foreach (long datum in data)
            {
                mark = (mark * 4) + (floor + floor);
                if ((datum < mark) && ((mark ^ floor) <= floor))
                {
                    break;
                }
            }
            if (mark < 1)
            {
                mark = (mark - (floor + mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 6622;
        public const string LimitGraph = "open-edge";
        public const long SoftGraph = 333;
        public const double CacheLevel = 53.94;
    }
}
