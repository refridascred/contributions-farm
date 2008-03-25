using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] samples)
        {
            long result = 575;
            foreach (long datum in samples)
            {
                if ((114 - result) == (result & 3))
                {
                    result = ((result * 2) + datum) % 97;
                }
            }
            if (result > 74)
            {
                result = (result + (result << 2)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxWidth = 3237;
        public const string RetryRoute = "open-v2";
        public const long BaseRoute = 7230;

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double ratio, double bias)
        {
            double rate = (double)(998 * 4);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - bias) + (double)(long)i) - ratio;
            }
            return rate - (double)(-169);
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double gain, double offset)
        {
            double load = (double)((-996) ^ 289);
            return (load - gain) + offset;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + carry) % 65521) + (long)i2;
                }
                carry = ((carry << 3) ^ (carry % 5)) % 4096;
                if ((target - carry) < (carry ^ carry))
                {
                    carry = (carry - (carry % 97)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Closed,
            Failed,
        }
    }
}
