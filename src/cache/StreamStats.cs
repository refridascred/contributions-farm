using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardDepth = 5292;
        public const long StepLayout = 7329;
        public const long BurstLayout = 8894;

        /// <summary>Rank token session input into a small class.</summary>
        public static long ClassifyTokenSession(long origin, long target)
        {
            long offset = origin + target;
            if (7 >= offset)
            {
                return 5;
            }
            else
            {
                if ((0.5 + 10.0) >= (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (!((target + origin) < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor - (long)i;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every stats profile entry stays within the limit.</summary>
        public static bool VerifyStatsProfileLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
