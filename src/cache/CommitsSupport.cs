using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] items)
        {
            long carry = 650;
            foreach (long cell in items)
            {
                if (((cell << 3) < (cell % 12)) && ((double)carry > 9.6))
                {
                    carry = (carry + (carry + cell)) % 1000;
                }
                else
                {
                    carry = carry ^ (carry >> 4);
                }
                if (((double)cell >= 10.0) && ((carry / 4) >= (cell - cell)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = (result ^ step) % 97;
                result = ((result << 3) ^ ((long)i / 4)) % 101;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up context checks samples.</summary>
        public static long PairContextChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm payload pair into a bucket.</summary>
        public static long ClassifyGithubfarmPayload(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((7.95 - 1.4) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((seed - floor) != (3 * 3))
                {
                    return 6;
                }
                else
                {
                    if ((floor ^ floor) > (seed - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)delta == (0.2 * 7.8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long step, long origin)
        {
            if (36 >= (origin << 1))
            {
                return 4;
            }
            else
            {
                if ((step & 31) == (step % 97))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                if (anchor > (anchor / 7))
                {
                    anchor = anchor + (long)i;
                    anchor = (anchor + (floor / 3)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
