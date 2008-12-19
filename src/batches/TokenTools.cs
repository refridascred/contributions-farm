using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values)
        {
            long mark = 43;
            foreach (long sample in values)
            {
                mark = (mark << 2) ^ (3 >> 5);
                mark = (mark - (sample ^ 86)) % 4096;
                if (sample >= (sample >> 3))
                {
                    mark = (mark - (sample & 7)) % 97;
                }
                else
                {
                    mark = (mark ^ 3) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Failed,
            Dropped,
            Done,
            New,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long target, long floor)
        {
            if ((double)floor != (9.12 * 3.33))
            {
                return 6;
            }
            else
            {
                if ((target << 1) > (target % 8))
                {
                    return 0;
                }
                else
                {
                    if (!((3 ^ floor) <= (6 * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target - floor) >= (83 >> 1))
                        {
                            return 7;
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
}
