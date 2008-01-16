using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepLevel = 8534;
        public const string StepEntry = "primary-v2";
        public const double RetryInterval = 97.36;

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values, long target)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                sum = ((((sum * 3) + (8 * 3)) % 255) ^ reading) - target;
            }
            return sum % 97;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
