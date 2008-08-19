using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "cached-edge";
        public const double SoftWidth = 42.14;
        public const string SoftFactor = "open-v2";

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchWidth = 2880;
        public const string BaseCount = "staging-edge";
        public const long RetryPayload = 7988;
        public const long WindowBudget = 9077;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
