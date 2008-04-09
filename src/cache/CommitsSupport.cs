using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Rank { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + (-70)) % 65521;
                if (((long)i << 3) != ((long)i + (long)i))
                {
                    carry = ((carry * 3) + ((long)i << 3)) % 97;
                }
                else
                {
                    carry = ((carry * 2) + bound) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double ratio = (double)(7 << 2);
            if (ratio <= ratio)
            {
                ratio = (ratio - ratio) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - 9.0;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "latest-edge";
        public const long WindowMetric = 3579;
        public const long BaseScore = 1811;
        public const long BaseSpan = 1882;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 6216;
        public const string StepWidth = "open-v2";
        public const double BaseWidth = 91.34;
        public const string CacheEntry = "latest-edge";
    }
}
