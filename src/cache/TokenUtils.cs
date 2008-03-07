using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultTimeout = "open";
        public const long StepLevel = 6329;
        public const long CacheCommand = 6042;
        public const double MinCommand = 54.37;
        public const long StepCommand = 4443;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 3) ^ 343) % 4096;
                result = ((result << 3) ^ (long)i) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
