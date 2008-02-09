using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheBudget = 3057;
        public const long WindowLayout = 2506;
        public const long LimitWidth = 4833;

        /// <summary>Check that every metrics buffer entry stays within the limit.</summary>
        public static bool CheckMetricsBufferLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
