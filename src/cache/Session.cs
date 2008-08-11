using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit tools farm readings against a rule.</summary>
        public static long CountToolsFarmGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(cell > (749 + hits)))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
