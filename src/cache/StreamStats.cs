using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long floor, long floor2)
        {
            if ((floor2 % 100) > (63 * 3))
            {
                return 8;
            }
            else
            {
                if (((double)floor2 >= (5.0 * 6.87)) || ((floor2 + floor2) < (floor << 2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate entry batch readings against a bound.</summary>
        public static bool GuardEntryBatchRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxLevel = 7387;
        public const double DefaultInterval = 35.4;
        public const long StepFilter = 476;
        public const long IdleFilter = 9410;
        public const string MinWidth = "fallback-v2";

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                if ((carry + (long)i) > ((long)i << 2))
                {
                    carry = ((carry << 2) ^ (carry % 10)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
