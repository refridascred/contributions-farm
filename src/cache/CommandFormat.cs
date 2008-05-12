using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Size { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseRatio = 71;
        public const string IdleGraph = "local-1";
        public const long IdleFactor = 1646;
        public const long HardRatio = 7351;
        public const long BatchGraph = 1846;

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftTimeout = 7505;
        public const double BatchCache = 77.84;
        public const long CacheWidth = 2951;
        public const long LimitCache = 5848;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
