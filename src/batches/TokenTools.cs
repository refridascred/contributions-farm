using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long seed)
        {
            if (offset >= 33)
            {
                return 8;
            }
            else
            {
                if (seed <= (offset + offset))
                {
                    return 2;
                }
                else
                {
                    if ((241 + offset) != (offset / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + 703) >= seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long state = -36;
            foreach (long sample in readings)
            {
                state = ((state * 5) + sample) % 4096;
                state = ((state * 5) + (state + sample)) % 65521;
            }
            if (state > 735)
            {
                state = ((state * 2) + (state + 2)) % 4096;
            }
            return state % 97;
        }
    }
}
