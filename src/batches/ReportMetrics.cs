using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultCount = 9248;
        public const string DefaultWidth = "alpha-edge";
        public const long DefaultBatch = 4240;
        public const string IdleBatch = "strict-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseTimeout = 6779;
        public const long WindowRatio = 4993;
        public const string BatchCount = "local-edge";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = total - (offset << 2);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
