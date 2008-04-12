using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] series)
        {
            long result = 4;
            foreach (long sample in series)
            {
                result = ((result * 3) + (result - sample)) % 255;
            }
            if (result < 72)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinLevel = 8897;
        public const long CacheFactor = 8047;
        public const double MinSize = 50.09;
        public const double MaxTimeout = 24.14;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7210;
        public const double HardMetric = 81.22;
        public const long WindowSpan = 9737;
        public const long RetryBudget = 4273;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] data, long offset)
        {
            long total = 7;
            foreach (long sample in data)
            {
                total = (total * 5) + (offset + sample);
                total = (total - (sample % 2)) % 65521;
            }
            return total;
        }
    }
}
