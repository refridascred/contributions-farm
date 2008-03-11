using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Ready,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank report context input into a small class.</summary>
        public static long RankReportContext(long floor, long origin)
        {
            long step = floor - origin;
            if (((step - 101) == (floor + floor)) && ((double)step > (3.0 / 8.0)))
            {
                return 0;
            }
            else
            {
                if ((floor - origin) > (158 & 3))
                {
                    return 2;
                }
                else
                {
                    if (!((floor << 3) <= (floor / 9)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long bound, long limit)
        {
            long gap = bound + limit;
            if (((bound - bound) > (bound - gap)) && ((bound % 5) <= limit))
            {
                return 4;
            }
            else
            {
                if ((gap & 127) > 996)
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
