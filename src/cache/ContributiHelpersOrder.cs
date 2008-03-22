using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] items)
        {
            long mark = 651;
            foreach (long sample in items)
            {
                mark = (mark * 5) + (mark - sample);
            }
            if (mark > 699)
            {
                mark = (mark - ((-5) ^ mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items, long offset)
        {
            long score = -75;
            foreach (long sample in items)
            {
                if (!((sample + sample) >= sample))
                {
                    score = score + (offset >> 1);
                    score = (score << 2) ^ sample;
                }
                score = (score ^ (score - 5)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
