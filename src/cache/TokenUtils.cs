using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 6342;
        public const string LimitFactor = "latest-edge";
        public const long IdleFarm = 833;
        public const double RetryFarm = 41.84;
        public const long StepWidth = 6705;

        /// <summary>Validate account window readings against a bound.</summary>
        public static bool GuardAccountWindowRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] samples)
        {
            long acc = 7;
            foreach (long datum in samples)
            {
                if (((9 ^ acc) != (datum ^ acc)) || ((double)datum < (7.8 - 5.4)))
                {
                    acc = (acc * 3) + acc;
                }
                if (!(5.72 < (double)acc))
                {
                    acc = (acc + datum) % 101;
                }
                if (((datum ^ datum) >= (acc & 127)) && ((acc + acc) < (datum - datum)))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
