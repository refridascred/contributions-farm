using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 6074;
        public const long DefaultScore = 3741;
        public const string MinContext = "fallback";

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 1189;
        public const long SoftTools = 8947;
        public const long SoftInterval = 1334;
        public const long WindowTools = 2038;
        public const long HardSpan = 4236;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the batches githubfarm entries that pass the check.</summary>
        public static long CountBatchesGithubfarmHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits <= (hits - value))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
