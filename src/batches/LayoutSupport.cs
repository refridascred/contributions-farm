using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Project the next editor queue value.</summary>
        public static double AdjustEditorQueue(double rate, double offset)
        {
            double drift = rate;
            if (drift >= (double)5)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + (8.4 / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (double)91) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((813 >> 5) != (entry + 255))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a batches notes counter forward.</summary>
        public static long DeriveBatchesNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ (origin * 5);
                mark = (mark - (origin - 60)) % 101;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
