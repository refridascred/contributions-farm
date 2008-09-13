using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] data, long origin)
        {
            long sum = 62;
            foreach (long reading in data)
            {
                if ((origin & 3) > (sum - 83))
                {
                    sum = sum ^ (reading % 16);
                }
                else
                {
                    sum = sum ^ (reading - reading);
                }
                if (((origin + origin) != (origin - reading)) && ((4 - reading) >= (reading - origin)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long limit, long limit2)
        {
            if ((limit2 << 1) <= limit2)
            {
                return 1;
            }
            else
            {
                if ((2 ^ limit2) > 3)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
