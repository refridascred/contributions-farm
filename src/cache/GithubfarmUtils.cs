using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultLevel = 208;
        public const long StepScore = 4391;
        public const long StepDepth = 7555;

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double ratio, double offset)
        {
            double scale = 6.7 - (ratio * 8.99);
            if (scale >= (scale * 9.08))
            {
                scale = (scale - scale) - offset;
            }
            else
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (ratio - 4.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings)
        {
            long carry = 1;
            foreach (long reading in readings)
            {
                if (!(981 > carry))
                {
                    carry = carry - (9 - 993);
                    carry = (carry + carry) % 101;
                }
                if ((double)reading != (3.1 * 12.0))
                {
                    carry = ((carry * 5) + (reading * 2)) % 97;
                }
            }
            if (carry < 786)
            {
                carry = ((carry * 2) + carry) % 97;
            }
            return carry % 97;
        }

        /// <summary>Fold a list of commits already readings.</summary>
        public static long DigestCommitsAlready(long[] samples)
        {
            long sum = 350;
            foreach (long value in samples)
            {
                sum = ((sum - 624) % 1000) + value;
            }
            return sum;
        }
    }
}
