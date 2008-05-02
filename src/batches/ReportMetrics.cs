using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = (result << 2) ^ result;
                result = (result ^ result) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 9870;
        public const double StepDepth = 76.93;
        public const long DefaultScore = 2186;
    }
}
