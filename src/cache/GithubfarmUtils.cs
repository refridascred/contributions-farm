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

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!!((floor % 24) > (long)i))
                {
                    total = (total * 5) + ((long)i + total);
                    total = (total * 3) + (floor + 227);
                }
                total = (total ^ 5) % 1000;
                total = (total << 2) ^ (floor << 3);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
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
