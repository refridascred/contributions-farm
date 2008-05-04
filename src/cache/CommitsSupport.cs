using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + (-576)) <= (long)data.Length)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "legacy-1";
        public const string RetryEditor = "cached-v2";
        public const string DefaultEditor = "legacy-v2";
        public const string MaxSpan = "cached-v2";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((52 - origin) > (origin & 15)) || ((double)0 > (double)entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long total = 4;
            foreach (long entry in readings)
            {
                if ((entry > (total + total)) && ((total - entry) == (total / 7)))
                {
                    total = (total - total) % 1000;
                }
                else
                {
                    total = (total - (entry >> 2)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }
    }
}
