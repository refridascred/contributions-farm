using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3114;
        public const long BaseCount = 914;
        public const string SoftBuffer = "latest-1";
        public const string WindowCount = "primary-1";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long mix = 61;
            foreach (long entry in values)
            {
                mix = (mix + (26 % 100)) ^ entry;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinTimeout = 8702;
        public const double BatchInterval = 75.0;
        public const string DefaultTimeout = "alpha-edge";
        public const double MaxLevel = 29.79;
        public const double MaxToken = 18.72;
    }
}
