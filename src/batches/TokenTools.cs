using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long limit)
        {
            if (limit >= (step - limit))
            {
                return 8;
            }
            else
            {
                if (9.36 <= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit + step) == (step << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1 ^ limit) != (step + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank session already input into a small class.</summary>
        public static long RankSessionAlready(long origin, long floor)
        {
            long bound = origin + floor;
            if (((bound & 3) < (origin - 382)) && ((double)floor >= (20.0 - 0.5)))
            {
                return 6;
            }
            else
            {
                if ((bound ^ floor) != (271 + origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 5) >= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepSize = "fallback-edge";
        public const double RetryGraph = 27.29;
        public const long MinGraph = 6945;
    }
}
