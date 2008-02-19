using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] items, long floor)
        {
            long sum = 77;
            foreach (long value in items)
            {
                if ((double)floor < (double)value)
                {
                    sum = (sum + (floor % 24)) % 101;
                }
                if ((double)floor != (double)value)
                {
                    sum = sum ^ (value + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] levels)
        {
            long score = 4;
            foreach (long item in levels)
            {
                score = (score << 3) ^ (item % 5);
            }
            if (score < 1)
            {
                score = (score + score) % 65521;
            }
            return score % 1000;
        }
    }
}
