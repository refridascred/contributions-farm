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

        /// <summary>Count context metrics pairs that satisfy a relation.</summary>
        public static long CompareContextMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Pending,
            Closed,
            Ready,
        }
    }
}
