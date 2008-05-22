using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftTimeout = 301;
        public const long WindowStats = 9008;
        public const long HardSize = 3860;

        /// <summary>Digest a series of farm stream entries.</summary>
        public static long TallyFarmStream(long[] levels)
        {
            long anchor = 711;
            foreach (long sample in levels)
            {
                anchor = (anchor * 2) + (sample << 1);
            }
            return anchor;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                long step2 = (step / 8) * 5;
                if (((step2 + step) > step2) && ((long)i > acc))
                {
                    step2 = ((step2 * 5) + ((long)i + step2)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double drift = weight * 9.0;
            if (drift < weight)
            {
                drift = (drift - drift) - bias;
            }
            return drift + weight;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCount = 1755;
        public const double BaseCommand = 80.76;
        public const string StepCount = "open-edge";
    }
}
