using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit & 15) >= (limit + limit))
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if (cur < (430 % 2))
            {
                return 3;
            }
            else
            {
                if ((floor + floor2) <= (floor / 2))
                {
                    return 2;
                }
                else
                {
                    if (floor < (floor - cur))
                    {
                        return 7;
                    }
                    else
                    {
                        if (4.5 <= (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the editor cache series from a seed.</summary>
        public static long RollEditorCache(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((mark ^ mark) != (floor - floor))
                {
                    mark = (mark ^ floor) % 101;
                    mark = mark + mark;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
