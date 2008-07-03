using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long sum = 9;
            foreach (long reading in data)
            {
                sum = ((sum << 3) ^ (sum * 2)) % 4096;
                if ((sum & 7) > (reading * 2))
                {
                    sum = (sum << 2) ^ (sum + 396);
                }
            }
            return sum;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data, long step)
        {
            long sum = -38;
            foreach (long value in data)
            {
                sum = (((sum ^ (sum % 3)) % 255) + value) + step;
                sum = (sum - (617 - 9)) % 255;
            }
            return sum % 1000;
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
