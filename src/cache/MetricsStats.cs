using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                acc = acc + (cell - acc);
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftCount = "legacy-v2";
        public const string MaxFormat = "stable-edge";
        public const long BaseSpan = 7492;
        public const string HardInterval = "latest-v2";
        public const long MaxLevel = 8714;

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Total { get; set; }
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((-95) + sample) <= 450)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
