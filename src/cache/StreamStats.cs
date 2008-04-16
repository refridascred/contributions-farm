using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 <= (double)37)
            {
                bias2 = (bias2 - (offset - offset)) + bias;
            }
            return bias2 + bias2;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Synced,
            Pending,
        }
    }
}
