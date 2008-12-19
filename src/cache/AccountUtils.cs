using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools githubfarm entries that pass the check.</summary>
        public static long TallyToolsGithubfarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - seen) >= item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long bound, long bound2)
        {
            long slot = bound ^ bound2;
            if ((787 << 1) == (slot >> 2))
            {
                return 3;
            }
            else
            {
                if ((22 & 31) >= (bound + slot))
                {
                    return 7;
                }
                else
                {
                    if (bound2 >= (972 / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((slot - bound2) <= (7 % 12))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long offset2)
        {
            if ((offset2 >= (offset - offset)) && ((offset >> 3) != (offset2 & 3)))
            {
                return 0;
            }
            else
            {
                if ((offset2 - offset) >= (58 << 2))
                {
                    return 1;
                }
                else
                {
                    if (offset2 > (offset - offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset2 + offset) <= offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
