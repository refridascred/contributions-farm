using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 8995;
        public const long LimitWidth = 8448;
        public const long MaxSize = 3899;
        public const long BurstCount = 9745;

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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            New,
            Closed,
            Pending,
            Synced,
            Locked,
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
