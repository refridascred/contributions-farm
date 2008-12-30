using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate report window samples.</summary>
        public static long WeighReportWindow(long[] items)
        {
            long carry = 3;
            foreach (long sample in items)
            {
                if ((4.4 / 8.0) != (double)sample)
                {
                    carry = (carry ^ (sample + sample)) % 255;
                }
            }
            if (carry > 2)
            {
                carry = (carry << 2) ^ (carry - (-1));
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheBudget = 5165;
        public const long RetryBudget = 4311;
        public const double RetryLevel = 44.29;
        public const long BatchMetrics = 6311;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 7739;
        public const long WindowSize = 8089;
        public const string StepBudget = "cached-edge";
        public const long MaxBudget = 5212;
        public const string LimitRatio = "legacy";
    }
}
