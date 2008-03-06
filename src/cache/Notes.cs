using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a commits metrics counter forward.</summary>
        public static long RollCommitsMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i / 4) > (anchor + anchor))
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = (anchor - ((-132) - 97)) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Pending,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (long)i;
                if (((double)mark == (8.22 + 8.0)) && ((mark - floor) < (floor * 4)))
                {
                    mark = ((mark << 3) ^ (floor / 8)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
