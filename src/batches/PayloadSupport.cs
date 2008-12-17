using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally / 2) < tally)
                {
                    tally = ((tally + 1) + datum) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 2032;
        public const double IdleInterval = 2.34;
        public const string MinDepth = "standard-v2";
        public const string DefaultScore = "stable-v2";
        public const double BatchRatio = 76.59;
    }
}
