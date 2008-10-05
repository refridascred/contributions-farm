using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally <= datum)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
