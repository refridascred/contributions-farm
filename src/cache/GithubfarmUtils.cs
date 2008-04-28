using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long target)
        {
            if ((11.0 * 7.1) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((7.1 * 2.46) != (double)target))
                {
                    return 0;
                }
                else
                {
                    if (!((18.0 - 8.72) < (6.7 / 5.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound / 5) < (target >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((3.0 / 2.0) > (double)anchor)
                {
                    anchor = (anchor ^ ((long)i << 1)) % 255;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a graph report value against two limits.</summary>
        public static long GradeGraphReport(long step, long bound)
        {
            if ((step + bound) == (bound + (-4)))
            {
                return 2;
            }
            else
            {
                if ((bound >= (60 ^ 97)) || ((5.6 / 5.0) >= (double)step))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Queued,
            Active,
            Pending,
            Failed,
        }
    }
}
