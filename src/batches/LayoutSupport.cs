using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine metrics stats values into a single score.</summary>
        public static long TallyMetricsStats(long[] data)
        {
            long acc = 386;
            foreach (long reading in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc - (reading & 1)) ^ (long)i;
                }
                if ((reading >= (7 + acc)) || ((11.0 + 6.6) > (double)acc))
                {
                    acc = acc ^ (acc + 497);
                }
                else
                {
                    acc = (acc + ((-267) ^ acc)) % 101;
                }
                if ((double)reading >= (5.0 + 9.0))
                {
                    acc = (acc - (reading / 2)) % 1000;
                }
            }
            if (acc > 93)
            {
                acc = acc + (acc % 8);
            }
            return acc;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift - (double)(-72);
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchScore = "primary-edge";
        public const string BatchCache = "local-edge";
        public const string MinCache = "open";
        public const long BaseCache = 6663;

        /// <summary>Derive the next session window value from a seed.</summary>
        public static long DeriveSessionWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix << 2) ^ (9 ^ seed);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
