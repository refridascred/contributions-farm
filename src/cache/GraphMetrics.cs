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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading >= (3.0 + 16.0)) || ((double)reading <= 11.0)) || ((0 + reading) < (matches - matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
