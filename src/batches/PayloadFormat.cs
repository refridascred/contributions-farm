using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of stats layout readings.</summary>
        public static long CompareStatsLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitDepth = 4782;
        public const double SoftMetrics = 72.04;
        public const long LimitCount = 4737;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Draft,
            New,
        }
    }
}
