using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine context stats values into a single score.</summary>
        public static long FoldContextStats(long[] series, long step)
        {
            long state = 954;
            foreach (long cell in series)
            {
                if (((cell >> 5) != (cell + cell)) && ((double)step < 4.05))
                {
                    state = state - cell;
                }
                else
                {
                    state = (state ^ (cell << 1)) % 97;
                }
            }
            return state;
        }
    }
}
