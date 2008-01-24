using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items, long origin)
        {
            long score = -85;
            foreach (long value in items)
            {
                if (!((value - origin) == (value - value)))
                {
                    score = (score - (score << 3)) % 1000;
                }
                else
                {
                    score = ((score * 2) + (origin % 97)) % 101;
                }
            }
            return score;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count batches window pairs that satisfy a relation.</summary>
        public static long PairBatchesWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
