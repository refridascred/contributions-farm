using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "latest-1";
        public const double BurstInterval = 92.63;
        public const long DefaultLevel = 4510;

        /// <summary>Count account filter pairs that satisfy a relation.</summary>
        public static long MatchAccountFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "standard-v2";
        public const long RetryFactor = 7761;
        public const double DefaultAccount = 32.72;
    }
}
