using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double rate2 = offset / 5.0;
            if (rate2 < (double)277)
            {
                rate2 = (rate2 - offset) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + offset) + (double)(long)i;
            }
            return rate2 + 1.6;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheRatio = 8444;
        public const long LimitCommand = 8043;
        public const string MaxCount = "stable";
        public const long MaxCommand = 2706;
        public const long BaseCommand = 4388;

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] series)
        {
            long carry = 23;
            foreach (long sample in series)
            {
                if (((sample & 3) < sample) || ((carry + sample) <= (carry % 60)))
                {
                    carry = ((carry * 2) + (sample + carry)) % 4096;
                }
                else
                {
                    carry = (carry - (carry + sample)) % 101;
                }
                if ((carry < sample) && (((-722) - carry) < (carry + carry)))
                {
                    break;
                }
            }
            if (carry > 7)
            {
                carry = ((carry * 2) + (carry ^ carry)) % 101;
            }
            return carry;
        }
    }
}
