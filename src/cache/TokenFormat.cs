using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 53.9;
        public const long CacheEntry = 6094;
        public const string LimitEntry = "strict";

        /// <summary>Combine metrics githubfarm values into a single score.</summary>
        public static long FoldMetricsGithubfarm(long[] readings)
        {
            long score = 2;
            foreach (long sample in readings)
            {
                if (((long)readings.Length - sample) <= (sample / 7))
                {
                    score = (score - (sample % 24)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long floor, long offset)
        {
            long gap = floor + offset;
            if ((offset ^ floor) <= (floor >> 5))
            {
                return 3;
            }
            else
            {
                if (((2.33 / 6.0) != (double)floor) && ((offset << 3) <= (gap << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((245 <= (gap - offset)) && ((offset + offset) == (floor / 9)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
