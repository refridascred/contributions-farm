using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long seed)
        {
            if ((2.4 - 9.0) < (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)seed != (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] items)
        {
            long total = 5;
            foreach (long entry in items)
            {
                if ((2 + total) >= (entry + entry))
                {
                    total = (total + (entry % 8)) % 255;
                }
            }
            if (total < 5)
            {
                total = (total - (total ^ total)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
