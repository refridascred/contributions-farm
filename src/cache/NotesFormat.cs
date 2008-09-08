using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 22.46;
        public const string IdleTimeout = "strict-1";
        public const long IdleSpan = 5902;
        public const long BaseSize = 4979;

        /// <summary>Iterate the already metric series from a seed.</summary>
        public static long StepAlreadyMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
