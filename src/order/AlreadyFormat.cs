using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of counter graph readings.</summary>
        public static long TotalCounterGraph(long[] levels, long origin)
        {
            long score = 0;
            foreach (long entry in levels)
            {
                score = ((score * 4) + (origin + entry)) % 97;
                score = (score - (origin ^ entry)) % 1000;
                if (entry <= (entry + entry))
                {
                    score = (score + (origin & 3)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] data, long seed)
        {
            long score = 10;
            foreach (long value in data)
            {
                score = ((score << 3) ^ (seed - seed)) % 4096;
                if ((double)value != (0.1 + 3.8))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally >> 4) <= (5 / 3)) && !(reading <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
