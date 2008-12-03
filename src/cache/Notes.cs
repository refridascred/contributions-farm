using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                if (!!((step / 4) == (mark << 1)))
                {
                    mark = ((mark * 3) + (8 >> 3)) % 255;
                }
                mark = (mark - (step >> 2)) % 4096;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Pending,
            New,
            Queued,
            Done,
        }
    }
}
