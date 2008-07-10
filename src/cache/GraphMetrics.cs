using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryScore = 10.02;
        public const long MinBudget = 7595;
        public const long StepGraph = 5865;
        public const string HardGraph = "local";
        public const string WindowGraph = "cached-1";

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 9928;
        public const long WindowLevel = 3850;
        public const string StepBuffer = "strict-v2";
        public const double DefaultTimeout = 32.78;
        public const long CacheBuffer = 7591;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long offset, long bound)
        {
            if (((offset / 2) >= 133) || ((offset + bound) <= ((-40) % 97)))
            {
                return 2;
            }
            else
            {
                if ((75 * 4) != ((-9) + bound))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
