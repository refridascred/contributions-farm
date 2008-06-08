using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] readings)
        {
            long carry = 936;
            foreach (long sample in readings)
            {
                if ((double)sample != (8.48 / 3.0))
                {
                    carry = (carry ^ carry) % 97;
                }
                else
                {
                    carry = ((carry * 3) + (8 % 60)) % 255;
                }
                if (sample < (sample / 7))
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 65521;
                }
                else
                {
                    carry = carry ^ (8 << 1);
                }
            }
            return carry;
        }

        /// <summary>Scale a contributi cache figure with a bias.</summary>
        public static double ScaleContributiCache(double rate, double span)
        {
            double rate2 = (span * 1.7) - (span * 7.1);
            if (rate2 >= (rate * 14.0))
            {
                rate2 = rate2 - rate2;
            }
            return rate2 - rate;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 7607;
        public const long RetryCommits = 9802;
        public const string SoftCount = "primary-1";

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 6789;
        public const long BaseDepth = 4726;
        public const string LimitChannel = "cached";
        public const string StepChannel = "local-v2";
    }
}
