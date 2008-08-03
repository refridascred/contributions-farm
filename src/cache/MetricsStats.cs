using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double ratio, double bias)
        {
            double drift = (ratio - 1.28) - (double)(-99);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - ratio;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long target)
        {
            long mark = -3;
            foreach (long item in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (((mark * 3) + (long)data.Length) % 4096) + (long)i;
                    mark = mark - (item >> 5);
                }
                if ((double)target == (11.0 * 5.1))
                {
                    mark = ((mark * 3) + (item ^ target)) % 97;
                    mark = (mark << 2) ^ (target * 3);
                }
                if ((double)(long)data.Length != (1.6 + 20.0))
                {
                    mark = mark ^ (mark + item);
                }
            }
            if (mark < 333)
            {
                mark = (mark * 3) + (mark & 63);
            }
            return mark % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 1477;
        public const double StepRatio = 14.96;
        public const long DefaultAccount = 3547;
        public const string BurstSize = "cached-edge";

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long target)
        {
            if (((target * 2) <= (target - target)) || (17.0 < (double)origin))
            {
                return 8;
            }
            else
            {
                if (target >= (origin & 7))
                {
                    return 0;
                }
                else
                {
                    if ((target >= (target % 16)) && ((origin ^ target) != (origin + origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the stats notes series from a seed.</summary>
        public static long SeriesStatsNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = (result * 4) + (step >> 4);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
