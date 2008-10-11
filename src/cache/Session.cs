using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "legacy-v2";
        public const double BurstRatio = 50.76;
        public const long MinLayout = 8747;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "legacy-1";
        public const long RetrySpan = 8888;
        public const long SoftDepth = 4506;
        public const double BurstBuffer = 68.53;

        /// <summary>Rank already profile input into a small class.</summary>
        public static long SortAlreadyProfile(long step, long seed)
        {
            if ((seed * 4) > (seed >> 2))
            {
                return 4;
            }
            else
            {
                if ((2.8 + 19.0) == (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (!((seed << 2) <= (step - step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step + seed) >= seed) && (1 < (seed << 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] values)
        {
            long mark = 5;
            foreach (long entry in values)
            {
                if (((22 + mark) == (mark % 60)) && ((double)entry < (5.72 / 3.0)))
                {
                    mark = (mark << 2) ^ entry;
                }
                else
                {
                    mark = ((mark << 2) ^ 849) % 101;
                }
            }
            return mark;
        }
    }
}
