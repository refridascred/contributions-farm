using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] items)
        {
            long mix = 33;
            foreach (long reading in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = (mix + (reading * 3)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix - (long)i2) % 1000;
                }
                mix = mix - (mix + (-29));
                if ((11.0 + 4.0) <= (double)reading)
                {
                    break;
                }
            }
            if (mix < 76)
            {
                mix = (mix * 3) + (mix * 4);
            }
            return mix % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxWidth = 9793;
        public const double StepTimeout = 83.79;
        public const long BurstPayload = 9511;
        public const string RetryPayload = "cached";
        public const long BurstTimeout = 4288;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (695 >= seen)
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
