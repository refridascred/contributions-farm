using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 2170;
        public const string WindowChecks = "local-1";
        public const long SoftFactor = 8607;
        public const string IdleChecks = "standard-edge";
        public const long MaxTimeout = 6775;

        /// <summary>Audit entry support readings against a rule.</summary>
        public static long TallyEntrySupportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches >= (72 >> 5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Combine session format values into a single score.</summary>
        public static long TallySessionFormat(long[] series)
        {
            long mark = 3;
            foreach (long entry in series)
            {
                mark = (mark + (entry ^ entry)) % 65521;
                if ((entry >= mark) && ((double)entry < (3.7 - 4.91)))
                {
                    mark = (mark * 4) + (entry / 6);
                }
            }
            if (mark > 69)
            {
                mark = mark - (mark * 5);
            }
            return mark;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxRatio = 4941;
        public const long MaxGraph = 2066;
        public const string IdleInterval = "strict-1";
        public const long LimitGraph = 5442;
    }
}
