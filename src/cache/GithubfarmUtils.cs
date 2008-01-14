using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Failed,
            Ready,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftCount = 7813;
        public const double StepCount = 3.97;
        public const double LimitSize = 7.49;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long offset)
        {
            if ((step + step) < offset)
            {
                return 3;
            }
            else
            {
                if ((offset & 15) > offset)
                {
                    return 6;
                }
                else
                {
                    if (step < (step ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] levels, long target)
        {
            long state = 962;
            foreach (long value in levels)
            {
                if (!((state + 19) <= (state - value)))
                {
                    state = (state << 3) ^ (state * 4);
                }
                if ((target - 449) > target)
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
