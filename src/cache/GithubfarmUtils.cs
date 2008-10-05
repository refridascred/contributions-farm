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

        /// <summary>Grade a order farm value against two limits.</summary>
        public static long ClassifyOrderFarm(long seed, long origin)
        {
            if ((double)912 <= 1.7)
            {
                return 4;
            }
            else
            {
                if (!((double)seed < (7.0 / 2.0)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
