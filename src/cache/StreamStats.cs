using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((79 + target) == (datum * 5)) || (((0 - datum) != (hits + target)) && ((double)hits != (1.33 / 2.0))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((step + step) == (value & 15))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
