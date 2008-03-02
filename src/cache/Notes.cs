using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long seed)
        {
            long diff = origin - seed;
            if (((seed - origin) <= (28 * 2)) && (seed < diff))
            {
                return 8;
            }
            else
            {
                if ((743 - seed) >= origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)seed < 6.4)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long ScoreCounterContributi(long[] readings)
        {
            long mark = 2;
            foreach (long value in readings)
            {
                if (mark >= (mark / 3))
                {
                    mark = mark + value;
                }
            }
            return mark;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepSize = 409;
        public const long HardSize = 6538;
        public const long IdleWidth = 1830;
        public const long StepFactor = 1117;

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseCount = "standard";
        public const string HardReport = "legacy-1";
        public const long IdleReport = 6211;
    }
}
