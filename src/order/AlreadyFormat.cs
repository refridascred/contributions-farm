using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] data, long origin)
        {
            long score = 5;
            foreach (long sample in data)
            {
                if ((origin >> 2) >= ((-2) + sample))
                {
                    score = (score + (547 >> 4)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series)
        {
            long mark = 65;
            foreach (long value in series)
            {
                if ((522 + 51) >= (value % 64))
                {
                    mark = (mark - value) % 1000;
                }
                else
                {
                    mark = ((mark * 4) + (value & 63)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Active,
            Ready,
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
