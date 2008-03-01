using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultLevel = 58;
        public const double WindowInterval = 54.48;
        public const long StepWidth = 2581;
        public const long MaxRatio = 3418;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchTimeout = 5022;
        public const long StepAlready = 2092;
        public const string MaxAlready = "cached-v2";
        public const double BatchAlready = 6.05;
    }
}
