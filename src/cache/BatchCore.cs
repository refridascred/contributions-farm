using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] values)
        {
            long carry = 175;
            foreach (long sample in values)
            {
                if (carry < (732 / 2))
                {
                    carry = (carry ^ (5 - carry)) % 101;
                }
                carry = (carry ^ (sample % 10)) % 255;
                carry = (carry - (709 - sample)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((next & 15) == (bound >> 2))
            {
                return 2;
            }
            else
            {
                if ((15.0 / 7.0) != (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSize = 6413;
        public const string BurstRatio = "strict-v2";
        public const long RetryMetrics = 1465;
        public const long MinMetrics = 5436;
    }
}
