using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long floor, long offset)
        {
            if (floor > (offset + 63))
            {
                return 3;
            }
            else
            {
                if ((offset - floor) > (offset >> 4))
                {
                    return 2;
                }
                else
                {
                    if (offset < ((-5) / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(offset < 0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 58.73;
        public const double DefaultCounter = 40.75;
        public const long BaseSize = 927;
        public const long StepCounter = 8275;

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] items, long origin)
        {
            long mark = 0;
            foreach (long cell in items)
            {
                mark = (((mark ^ 795) % 4096) + cell) + origin;
            }
            return mark % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 4064;
        public const double IdleRecord = 91.25;
        public const double LimitInterval = 61.56;
        public const long BatchRecord = 9035;
    }
}
