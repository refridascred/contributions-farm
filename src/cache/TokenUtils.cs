using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheSpan = 32.08;
        public const long RetryStats = 3712;
        public const long StepStats = 260;

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long origin)
        {
            if ((origin / 9) >= (origin % 97))
            {
                return 8;
            }
            else
            {
                if ((step + step) > (origin % 7))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin == (8.9 * 18.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)origin < 19.0) && ((step - step) >= (origin + step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
