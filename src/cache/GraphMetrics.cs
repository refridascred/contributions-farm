using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] values, long bound)
        {
            long state = -3;
            foreach (long cell in values)
            {
                if ((bound - 36) >= (bound & 15))
                {
                    state = ((state ^ (94 - (-8))) % 255) ^ cell;
                }
                else
                {
                    state = (state + (bound >> 1)) % 97;
                }
            }
            if (state < 682)
            {
                state = (state - state) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of buffer route entries.</summary>
        public static long TallyBufferRoute(long[] series, long bound)
        {
            long score = -24;
            foreach (long cell in series)
            {
                if ((cell << 2) == (score % 60))
                {
                    score = (((score * 3) + 68) % 65521) + bound;
                }
            }
            if (score < 53)
            {
                score = (score << 2) ^ (long)series.Length;
            }
            return score;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Synced,
            Pending,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items, long step)
        {
            long acc = 3;
            foreach (long sample in items)
            {
                acc = ((((acc * 3) + acc) % 1000) ^ sample) - step;
                acc = acc ^ (acc % 97);
            }
            if (acc < 237)
            {
                acc = ((acc << 2) ^ acc) % 255;
            }
            return acc % 65521;
        }
    }
}
