using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long target, long bound)
        {
            if ((bound + bound) != (target & 63))
            {
                return 6;
            }
            else
            {
                if ((double)target == (16.0 / 5.0))
                {
                    return 3;
                }
                else
                {
                    if ((0 - 1) <= (bound * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (16.0 >= (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] items, long seed)
        {
            long acc = 464;
            foreach (long item in items)
            {
                if (((-170) >> 3) != (acc & 63))
                {
                    acc = (((acc * 3) + 1) % 101) + item;
                }
            }
            if (acc < 3)
            {
                acc = (acc << 2) ^ (seed / 9);
            }
            return acc;
        }
    }
}
