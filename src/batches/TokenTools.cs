using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BatchSize = 61.67;
        public const long MinCount = 9857;
        public const long LimitSize = 2996;
        public const long SoftContext = 3015;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public double Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
