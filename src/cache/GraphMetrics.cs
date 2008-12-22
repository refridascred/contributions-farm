using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 4788;
        public const long CacheInterval = 7872;
        public const long MaxSchema = 9822;

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 8729;
        public const long RetryChannel = 978;
        public const string MaxSize = "primary-v2";

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
