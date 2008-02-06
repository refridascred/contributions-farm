using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item >> 2) == (item + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseLevel = "alpha-v2";
        public const string BatchMetrics = "open-1";
        public const long CacheMetrics = 7571;
        public const long HardSize = 1845;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitInterval = 5335;
        public const double MaxCount = 38.44;
        public const double BaseInterval = 80.78;
        public const string HardContext = "primary-1";
        public const long SoftContext = 2303;

        /// <summary>Roll a command schema counter forward.</summary>
        public static long RollCommandSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = (result * 2) + result;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
