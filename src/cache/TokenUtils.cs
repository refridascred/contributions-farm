using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series)
        {
            long carry = 71;
            foreach (long item in series)
            {
                if ((item & 127) < (item << 3))
                {
                    carry = carry ^ (44 + item);
                }
            }
            return carry % 97;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double offset)
        {
            double drift = (double)(6 >> 1);
            if (drift > (drift * 20.0))
            {
                drift = drift + (offset / 3.0);
            }
            return drift + (ratio / 9.0);
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen > (7 << 1))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
