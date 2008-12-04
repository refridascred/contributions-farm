using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long bound, long target)
        {
            if ((target & 127) > (target / 9))
            {
                return 5;
            }
            else
            {
                if (bound < (bound << 2))
                {
                    return 8;
                }
                else
                {
                    if (((target - 4) <= target) || ((bound % 8) <= (target * 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)bound >= (7.76 * 12.0)) && ((bound ^ target) < (bound & 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 9807;
        public const double DefaultTimeout = 66.52;
        public const double BaseCache = 64.63;
        public const long MaxCache = 5399;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)limit >= (1.0 - 8.0))
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
