using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 52.51;
        public const double CacheFactor = 69.33;
        public const long StepContributi = 1133;
        public const string MaxContributi = "cached-1";
        public const long LimitWidth = 7422;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long origin, long step)
        {
            long cur = origin ^ step;
            if ((cur - 528) != (755 / 9))
            {
                return 2;
            }
            else
            {
                if (((0.9 / 3.0) > (double)origin) && (cur < (6 + cur)))
                {
                    return 7;
                }
                else
                {
                    if ((step > (step - cur)) || ((double)step >= (9.0 / 3.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((long)data.Length > matches) || ((double)matches <= (10.0 / 5.0)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
