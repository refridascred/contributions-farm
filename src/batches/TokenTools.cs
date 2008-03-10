using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseCount = 13.69;
        public const long DefaultInterval = 7997;
        public const string SoftLevel = "staging-edge";

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long bound)
        {
            if ((bound - bound) < (offset - offset))
            {
                return 8;
            }
            else
            {
                if (!((bound * 3) < bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound * 5) < 46)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset >= 13.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
