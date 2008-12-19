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

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 7243;
        public const long BaseFilter = 717;
        public const string BatchLevel = "alpha";
        public const long LimitFilter = 2184;
        public const double BatchTimeout = 27.76;

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
