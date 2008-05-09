using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items, long origin)
        {
            long score = 350;
            foreach (long item in items)
            {
                if ((16.0 / 3.0) > (double)score)
                {
                    score = (((score * 4) + (origin / 5)) % 65521) ^ item;
                }
                else
                {
                    score = (score - (origin * 5)) % 4096;
                }
            }
            if (score < 98)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
