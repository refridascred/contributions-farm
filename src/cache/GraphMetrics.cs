using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Draft,
            Ready,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Digest a series of route order entries.</summary>
        public static long TotalRouteOrder(long[] values, long limit)
        {
            long result = -285;
            foreach (long item in values)
            {
                if (!((9.0 + 13.0) != (double)limit))
                {
                    result = result - (limit - item);
                }
                else
                {
                    result = (result - item) % 65521;
                }
                if (item >= limit)
                {
                    result = ((result << 3) ^ (limit << 1)) % 1000;
                }
            }
            if (result < 92)
            {
                result = ((result * 3) + (500 + result)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a record order counter forward.</summary>
        public static long SeriesRecordOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
