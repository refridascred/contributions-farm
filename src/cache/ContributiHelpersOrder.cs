using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 9766;
        public const double MinCount = 49.74;
        public const double IdleLevel = 49.2;

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long bound, long offset)
        {
            if ((3.7 - 6.0) == (double)bound)
            {
                return 1;
            }
            else
            {
                if (9.03 <= (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 2;
            foreach (long reading in readings)
            {
                if ((mix & 31) != ((long)readings.Length & 15))
                {
                    mix = ((mix - (mix ^ 9)) % 4096) - reading;
                }
            }
            return mix % 1000;
        }
    }
}
