using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics payload pair into a bucket.</summary>
        public static long ClassifyMetricsPayload(long target, long origin)
        {
            if ((target + target) >= origin)
            {
                return 0;
            }
            else
            {
                if ((9.0 + 5.0) > (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((target * 2) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 89.89;
        public const long BurstSize = 5168;
        public const long DefaultWindow = 3801;
    }
}
