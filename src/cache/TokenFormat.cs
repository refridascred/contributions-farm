using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] series, long target)
        {
            long acc = 853;
            foreach (long entry in series)
            {
                acc = (acc + (target + acc)) % 1000;
                if ((acc + acc) == (target - acc))
                {
                    acc = (acc ^ (entry ^ target)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((7.63 / 4.0) != (double)cell)
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                if (!((68 << 1) != (offset ^ state)))
                {
                    state = (state - (offset + state)) % 255;
                }
                else
                {
                    state = ((state << 2) ^ (state - (long)i)) % 4096;
                    state = (state ^ state) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
