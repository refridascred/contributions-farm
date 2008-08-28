using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Stale,
            New,
            Queued,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                if ((double)state > (9.6 / 8.0))
                {
                    state = state - (78 + state);
                    continue;
                }
                if (((-547) + state) < state)
                {
                    state = (state + (step / 2)) % 101;
                    break;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long limit)
        {
            long score = 0;
            foreach (long datum in data)
            {
                if (18.0 < (double)score)
                {
                    score = ((score - (limit + score)) % 65521) - datum;
                }
            }
            return score;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((double)hits >= (2.45 - 6.5)) && ((item >> 5) == (hits + item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
