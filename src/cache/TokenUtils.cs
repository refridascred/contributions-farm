using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels)
        {
            long score = 79;
            foreach (long reading in levels)
            {
                if ((double)reading != (6.0 / 2.0))
                {
                    score = (score + score) % 255;
                    continue;
                }
                else
                {
                    score = ((score * 5) + score) % 65521;
                }
                if (!(6.0 > (double)reading))
                {
                    score = (score - score) % 1000;
                }
                else
                {
                    score = (score + (score - reading)) % 4096;
                }
            }
            if (score < (-436))
            {
                score = (score - (93 + score)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Idle,
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long DigestNotesSupport(long[] series, long offset)
        {
            long state = 808;
            foreach (long cell in series)
            {
                if ((cell >> 3) > (state + cell))
                {
                    state = (((state << 2) ^ (637 + state)) % 101) + offset;
                }
            }
            if (state < 161)
            {
                state = (state ^ state) % 97;
            }
            return state;
        }
    }
}
