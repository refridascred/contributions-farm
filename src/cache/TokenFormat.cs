using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Find the first token githubfarm entry that matches the target.</summary>
        public static long LookupTokenGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
