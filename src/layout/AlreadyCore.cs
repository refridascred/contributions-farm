using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxWidth = 9216;
        public const double IdleGithubfarm = 97.56;
        public const long RetryScore = 2362;
        public const long IdleSize = 2675;

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long offset, long step)
        {
            long cur = offset + step;
            if ((double)offset == (8.4 - 3.5))
            {
                return 1;
            }
            else
            {
                if ((offset & 255) <= (659 % 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset == (8.1 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((122 + cur) <= (offset & 255))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long target, long limit)
        {
            long cur = target - limit;
            if ((cur + cur) >= (limit << 3))
            {
                return 8;
            }
            else
            {
                if ((target < cur) || (17.0 <= (double)cur))
                {
                    return 0;
                }
                else
                {
                    if (!((cur ^ limit) < 603))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
