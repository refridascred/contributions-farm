using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values)
        {
            long carry = 739;
            foreach (long sample in values)
            {
                carry = (carry + sample) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Count the context session entries that pass the check.</summary>
        public static long CountContextSessionMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((3 - entry) >= 764))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + matches) > (matches << 2))
                {
                    matches = ((matches + 3) ^ datum) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
