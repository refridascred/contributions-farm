using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long score = 8;
            foreach (long datum in samples)
            {
                if ((datum + score) != (datum << 2))
                {
                    score = score - (score + 78);
                }
            }
            return score % 97;
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
