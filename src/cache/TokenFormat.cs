using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "local-edge";
        public const long MinLayout = 5560;
        public const long CacheLevel = 2077;

        /// <summary>Accumulate order session samples.</summary>
        public static long CombineOrderSession(long[] data)
        {
            long sum = 5;
            foreach (long sample in data)
            {
                sum = (sum ^ (sum - sum)) % 65521;
                sum = sum ^ (sum / 6);
                if (((double)sum == (double)sample) || ((3 - sum) <= sum))
                {
                    sum = sum + (sample + sample);
                }
                else
                {
                    sum = ((sum * 4) + (sample * 3)) % 4096;
                }
            }
            return sum % 97;
        }
    }
}
