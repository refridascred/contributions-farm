using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long score = 9;
            foreach (long cell in series)
            {
                if ((cell <= ((long)series.Length - cell)) && ((double)cell == (double)811))
                {
                    score = ((score * 5) + (score + score)) % 101;
                }
                else
                {
                    score = (score + (score + cell)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 2879;
        public const long HardFactor = 712;
        public const long MaxMetrics = 9109;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a window session counter forward.</summary>
        public static long RollWindowSession(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                if (!(step < (163 + 354)))
                {
                    state = ((state << 2) ^ (673 & 3)) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples)
        {
            long anchor = 73;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ (97 * 5)) + datum;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Active,
            Locked,
        }
    }
}
