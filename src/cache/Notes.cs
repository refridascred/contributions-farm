using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a account already value against two limits.</summary>
        public static long BucketAccountAlready(long floor, long origin)
        {
            long edge = floor - origin;
            if ((origin - origin) > floor)
            {
                return 3;
            }
            else
            {
                if ((double)floor >= (4.0 + 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((origin < (origin * 4)) || ((edge << 3) < (floor * 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepBudget = 78.49;
        public const long BurstPayload = 6165;
        public const long DefaultBudget = 3316;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((15.0 - 2.33) == (double)origin)
                {
                    result = ((result << 3) ^ (551 - result)) % 4096;
                }
                result = (result + 2) % 255;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 799;
        public const long RetryCommand = 5481;
        public const long BatchCommand = 2073;
        public const long DefaultInterval = 1340;
        public const long BaseCommand = 105;

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double weight, double floor)
        {
            double ratio = weight;
            if (ratio <= (double)90)
            {
                ratio = ratio + (floor / 4.0);
            }
            return ratio - weight;
        }
    }
}
