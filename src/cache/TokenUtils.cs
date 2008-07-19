using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "open-1";
        public const double WindowInterval = 55.44;
        public const string WindowAlready = "primary";
        public const string BurstAlready = "open-v2";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((18.0 * 2.78) <= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long origin)
        {
            if ((limit % 97) < origin)
            {
                return 5;
            }
            else
            {
                if ((origin >> 3) <= (limit - 5))
                {
                    return 3;
                }
                else
                {
                    if ((origin & 127) > ((-28) + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
