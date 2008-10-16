using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate schema layout readings against a bound.</summary>
        public static bool GuardSchemaLayoutLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Retry,
            Draft,
            Synced,
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
