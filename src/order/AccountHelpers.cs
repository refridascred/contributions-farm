using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = (state - (529 - (long)i)) % 255;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long anchor = 1;
            foreach (long cell in samples)
            {
                if ((cell & 255) != (anchor + anchor))
                {
                    anchor = (anchor * 5) + (cell + cell);
                }
                anchor = anchor ^ cell;
            }
            if (anchor < 5)
            {
                anchor = (anchor + (anchor & 127)) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (12.0 - 1.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series)
        {
            long acc = 3;
            foreach (long entry in series)
            {
                acc = (acc ^ acc) - entry;
                if ((acc / 4) < (acc >> 1))
                {
                    acc = ((acc << 2) ^ (acc % 10)) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}
