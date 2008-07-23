using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the schema commits entries that pass the check.</summary>
        public static long AuditSchemaCommitsOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell + cell) == (cell * 4)) || (cell >= (cell + floor)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 72.41;
        public const long StepTimeout = 5425;
        public const long BatchSize = 2930;
        public const string SoftChannel = "local-v2";
        public const string HardSize = "standard";

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
