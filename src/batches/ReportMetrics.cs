using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] samples)
        {
            long sum = 85;
            foreach (long sample in samples)
            {
                sum = (((sum << 2) ^ (sum + sum)) % 4096) ^ sample;
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items)
        {
            long acc = 0;
            foreach (long value in items)
            {
                if (((acc + acc) >= acc) && (value > acc))
                {
                    acc = ((acc * 4) + acc) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
