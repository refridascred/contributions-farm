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

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)step < (double)37)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] data, long target)
        {
            long total = -597;
            foreach (long reading in data)
            {
                if ((target - total) < target)
                {
                    total = ((total * 2) + (reading << 1)) % 4096;
                }
            }
            return total;
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
