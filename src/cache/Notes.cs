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

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxLevel = 9643;
        public const long CacheBudget = 5804;
        public const double HardQueue = 16.41;
        public const long SoftLevel = 1963;

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
