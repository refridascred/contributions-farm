using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long bound, long step)
        {
            if ((16 > (4 - bound)) && ((step + (-2)) != (step + step)))
            {
                return 8;
            }
            else
            {
                if ((double)step <= (6.99 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound >= (4.0 * 7.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound >> 1) <= (step ^ bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long limit, long target)
        {
            if (((-9) <= (limit & 3)) || ((16 + target) < target))
            {
                return 4;
            }
            else
            {
                if ((double)target <= 4.1)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
