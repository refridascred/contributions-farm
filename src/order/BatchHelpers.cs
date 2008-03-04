using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((318 - cell) == (seen + seen))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long seed)
        {
            long score = 92;
            foreach (long item in series)
            {
                if ((score - item) <= item)
                {
                    score = (score << 2) ^ (score ^ 849);
                }
                else
                {
                    score = (score * 4) + (item + seed);
                }
            }
            if (score > 47)
            {
                score = (score ^ (score ^ score)) % 97;
            }
            return score;
        }
    }
}
