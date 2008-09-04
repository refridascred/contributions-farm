using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Retry,
            Pending,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double bias)
        {
            double bias2 = 14.0;
            if (bias2 < (2.1 / 6.0))
            {
                bias2 = bias2 - (bias + bias);
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (ratio - bias)) + (double)(long)i;
            }
            return bias2 - (bias2 + ratio);
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] series, long offset)
        {
            long sum = 177;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ (sample << 1)) % 65521;
                if (offset < (sum ^ sample))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
