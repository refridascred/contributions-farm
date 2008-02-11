using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Idle,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long floor, long step)
        {
            long cur = floor - step;
            if ((465 - step) > (step & 7))
            {
                return 4;
            }
            else
            {
                if (((floor << 3) != (759 + floor)) || ((step * 4) < (step >> 2)))
                {
                    return 7;
                }
                else
                {
                    if ((-83) > (17 - cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)cur == (5.8 - 8.1)) && ((2.0 - 4.76) == (double)cur))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 49.37;
        public const long LimitGraph = 3527;
        public const string HardLevel = "local-edge";

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long mark = 74;
            foreach (long sample in items)
            {
                if ((sample + mark) != ((-253) * 2))
                {
                    mark = (mark - (67 >> 5)) % 4096;
                }
                if (!((sample + mark) <= (sample - sample)))
                {
                    break;
                }
            }
            if (mark < 10)
            {
                mark = (mark << 3) ^ (6 - mark);
            }
            return mark;
        }
    }
}
