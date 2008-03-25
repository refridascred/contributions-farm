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

        /// <summary>Classify a command account pair into a bucket.</summary>
        public static long RankCommandAccount(long seed, long bound)
        {
            long edge = seed - bound;
            if ((double)bound >= (1.0 + 11.0))
            {
                return 6;
            }
            else
            {
                if (!(bound < (edge ^ seed)))
                {
                    return 2;
                }
                else
                {
                    if ((9.11 + 9.2) == (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((11.0 * 7.7) >= (double)edge)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
