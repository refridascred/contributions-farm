using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] series)
        {
            long sum = -561;
            foreach (long sample in series)
            {
                if ((sum < (446 % 12)) || ((5.5 + 0.5) <= (double)sum))
                {
                    sum = (sum - (sample << 3)) % 1000;
                }
                else
                {
                    sum = ((sum * 5) + (sample / 4)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            New,
            Pending,
            Failed,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySize = 6786;
        public const long StepRatio = 8649;
        public const double WindowMetrics = 42.2;

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels)
        {
            long mark = 39;
            foreach (long reading in levels)
            {
                if ((6.7 / 3.0) > (double)mark)
                {
                    mark = (((mark * 4) + mark) % 4096) + reading;
                }
            }
            return mark % 1000;
        }
    }
}
