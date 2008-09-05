using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitRatio = 43.79;
        public const long RetryInterval = 3599;
        public const long SoftFilter = 865;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long origin)
        {
            long step = target - origin;
            if ((double)target < (double)step)
            {
                return 3;
            }
            else
            {
                if ((target % 100) < step)
                {
                    return 5;
                }
                else
                {
                    if ((step - target) > (origin - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target - target) > (origin + origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseSize = 2501;
        public const double MinSize = 31.3;
        public const long MaxStats = 1789;

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] data, long origin)
        {
            long mix = 940;
            foreach (long cell in data)
            {
                if ((cell * 2) >= (mix - cell))
                {
                    mix = (mix + (3 * 5)) % 1000;
                }
                else
                {
                    mix = ((mix * 4) + (origin ^ 1)) % 97;
                }
            }
            if (mix > 764)
            {
                mix = (mix * 5) + (mix + mix);
            }
            return mix % 97;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long limit, long target)
        {
            if (target > (76 & 31))
            {
                return 2;
            }
            else
            {
                if (0.84 <= (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((10.0 / 2.0) <= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
