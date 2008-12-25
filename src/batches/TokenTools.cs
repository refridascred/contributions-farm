using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((bound + (long)items.Length) >= (datum / 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4993;
        public const long MaxCache = 16;
        public const long MaxSpan = 2508;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
