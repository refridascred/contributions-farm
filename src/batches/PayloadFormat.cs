using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultTimeout = 3707;
        public const long BaseBudget = 7609;
        public const long LimitRoute = 4110;
        public const double HardScore = 7.69;
        public const string SoftCount = "legacy-1";

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings, long bound)
        {
            long result = 1;
            foreach (long item in readings)
            {
                result = (((result - 0) % 65521) - item) - bound;
            }
            return result;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] values, long limit)
        {
            long anchor = 87;
            foreach (long entry in values)
            {
                anchor = ((anchor * 4) + anchor) + entry;
                if ((16.0 * 1.7) >= (double)limit)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            New,
            Draft,
        }
    }
}
