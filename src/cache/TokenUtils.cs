using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string HardTimeout = "stable-edge";
        public const long RetryPayload = 4876;
        public const long MinPayload = 403;
        public const long BaseWidth = 8748;

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long floor, long origin)
        {
            if (5.2 < (double)floor)
            {
                return 1;
            }
            else
            {
                if ((floor - floor) <= floor)
                {
                    return 3;
                }
                else
                {
                    if ((origin + floor) > ((-6) + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + floor) > (origin % 60))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] data)
        {
            long sum = 756;
            foreach (long datum in data)
            {
                sum = ((sum << 2) ^ (57 + (long)data.Length)) % 1000;
                if (datum > (datum - 133))
                {
                    break;
                }
            }
            if (sum < 7)
            {
                sum = sum - sum;
            }
            return sum;
        }
    }
}
