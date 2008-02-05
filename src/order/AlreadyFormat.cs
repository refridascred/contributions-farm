using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 7109;
        public const double HardSize = 97.07;
        public const long MinBatch = 1839;
        public const string WindowInterval = "stable-v2";
        public const string DefaultBatch = "strict-1";

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 6410;
        public const long BaseCounter = 1180;
        public const double CacheCounter = 86.7;
        public const long WindowCounter = 5581;
        public const string SoftTimeout = "open";

        /// <summary>Project the next context batches value.</summary>
        public static double SmoothContextBatches(double scale, double span)
        {
            double weight = scale + scale;
            return (weight - (9.9 + weight)) + span;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
