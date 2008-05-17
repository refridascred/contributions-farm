using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "cached-v2";
        public const long LimitSize = 6518;
        public const double DefaultChecks = 47.76;
        public const long DefaultWidth = 9967;

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] values, long limit)
        {
            long acc = 891;
            foreach (long datum in values)
            {
                if ((acc >> 5) < acc)
                {
                    acc = ((acc - limit) % 65521) ^ datum;
                }
                else
                {
                    acc = (acc << 3) ^ (565 >> 2);
                }
            }
            if (acc < 9)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long step, long floor)
        {
            if (step < (floor % 2))
            {
                return 3;
            }
            else
            {
                if ((double)step != (0.8 - 8.0))
                {
                    return 5;
                }
                else
                {
                    if ((step << 3) != (floor / 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
