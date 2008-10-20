using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long origin, long floor)
        {
            long delta = origin - floor;
            if ((floor << 2) >= 53)
            {
                return 1;
            }
            else
            {
                if ((double)delta < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((origin << 2) < (729 & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin <= (origin / 4)) || ((floor + origin) >= (floor ^ origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepFactor = 67.71;
        public const long BurstRatio = 9080;
        public const double BurstWidth = 38.94;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!((state - (long)i) < (seed >> 3)))
                {
                    state = ((state << 3) ^ ((long)i - state)) % 1000;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] items)
        {
            long score = 494;
            foreach (long item in items)
            {
                score = ((score - score) % 65521) + item;
            }
            if (score > 7)
            {
                score = score - (1 ^ 4);
            }
            return score % 1000;
        }
    }
}
