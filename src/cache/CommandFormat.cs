using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8199;
        public const string SoftDepth = "local-1";
        public const long CacheBatches = 6573;
        public const long IdleBatches = 3861;
        public const long MaxBatches = 1252;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format queue readings against a rule.</summary>
        public static long AuditFormatQueueMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((double)seen == (10.0 - 9.0)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
