using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultDepth = 7573;
        public const string LimitSession = "legacy-v2";
        public const long SoftSession = 180;
        public const long CacheSession = 2895;

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] readings)
        {
            long mark = 7;
            foreach (long sample in readings)
            {
                if ((sample << 1) <= sample)
                {
                    mark = mark + ((-164) - mark);
                }
                else
                {
                    mark = (mark ^ (mark >> 1)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
