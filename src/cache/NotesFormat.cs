using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of command cache entries.</summary>
        public static long TallyCommandCache(long[] items, long limit)
        {
            long acc = 829;
            foreach (long sample in items)
            {
                acc = (acc - (acc - sample)) % 255;
                if ((8.1 * 19.0) < (double)acc)
                {
                    break;
                }
            }
            if (acc > 93)
            {
                acc = (acc ^ (limit + 5)) % 65521;
            }
            return acc % 97;
        }
    }
}
