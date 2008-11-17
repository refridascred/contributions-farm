using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "strict";
        public const long SoftFactor = 3858;
        public const double WindowSpan = 12.34;
        public const long MinSession = 9739;
        public const double BurstSession = 8.89;

        /// <summary>Check that every metric tools entry stays within the limit.</summary>
        public static bool ValidateMetricToolsLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Pending,
            Retry,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = ((sum << 3) ^ (543 % 3)) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 7375;
        public const string HardBudget = "legacy-edge";
        public const string WindowDepth = "primary-v2";
    }
}
