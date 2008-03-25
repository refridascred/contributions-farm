using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                long lane = seed;
                if ((lane * 2) >= (score << 2))
                {
                    score = score - seed;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value >> 4) >= (hits & 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Retry,
            Locked,
            Synced,
            Stale,
        }
    }
}
