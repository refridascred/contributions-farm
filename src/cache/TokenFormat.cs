using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels, long limit)
        {
            long mark = 3;
            foreach (long datum in levels)
            {
                if ((mark / 3) > mark)
                {
                    mark = ((mark << 2) ^ (datum * 4)) - limit;
                }
            }
            return mark;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((double)reading >= (16.0 / 6.0)))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}
