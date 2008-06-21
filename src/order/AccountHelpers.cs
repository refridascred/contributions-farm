using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Failed,
            Dropped,
            Closed,
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= bias)
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (mean / 5.0);
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double scale, double span)
        {
            double mean = (scale / 4.0) - (double)885;
            return (mean + mean) + span;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] samples)
        {
            long carry = 956;
            foreach (long cell in samples)
            {
                carry = (carry + (cell * 4)) % 65521;
                carry = (carry + ((-305) + 3)) % 97;
                if (133 < (cell * 4))
                {
                    carry = (carry * 3) + (cell & 15);
                }
            }
            return carry % 4096;
        }
    }
}
