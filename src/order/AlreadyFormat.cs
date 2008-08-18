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

        /// <summary>Combine context metrics values into a single score.</summary>
        public static long TallyContextMetrics(long[] readings)
        {
            long result = 9;
            foreach (long reading in readings)
            {
                if (reading >= (result % 12))
                {
                    result = (result - (reading + result)) % 1000;
                }
                else
                {
                    result = (result << 2) ^ (result / 7);
                }
            }
            if (result < 8)
            {
                result = (result * 4) + (81 % 5);
            }
            return result;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchWidth = 2880;
        public const string BaseCount = "staging-edge";
        public const long RetryPayload = 7988;
        public const long WindowBudget = 9077;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }
    }
}
