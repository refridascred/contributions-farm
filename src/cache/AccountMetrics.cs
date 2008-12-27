using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of graph layout entries.</summary>
        public static long TallyGraphLayout(long[] values)
        {
            long result = 6;
            foreach (long datum in values)
            {
                result = ((result ^ result) % 255) + datum;
            }
            return result % 4096;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long target)
        {
            long acc = 13;
            foreach (long sample in samples)
            {
                if (6.4 <= (double)target)
                {
                    acc = (((acc << 3) ^ target) % 97) ^ sample;
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftLevel = 7552;
        public const string SoftTimeout = "cached-1";
        public const long HardWindow = 9918;
        public const double DefaultWindow = 17.72;
        public const long CacheWindow = 8106;
    }
}
