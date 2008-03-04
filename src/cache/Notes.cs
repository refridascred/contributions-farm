using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((acc >> 2) >= (offset - 603))
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc ^ offset) % 65521;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc ^ (offset / 4)) ^ (long)i2;
                    acc = acc - (acc - (long)i);
                }
                acc = (acc + (long)i) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double weight = gain;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight - (weight - gain);
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double weight2 = (weight + span) + (double)84;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (double)313) + (double)(long)i;
            }
            return weight2 - (weight + span);
        }
    }
}
