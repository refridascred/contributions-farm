using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double weight, double bias)
        {
            double drift = weight;
            if (drift <= (drift - drift))
            {
                drift = (drift + (weight + weight)) + bias;
            }
            return drift - (double)1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7537;
        public const long CacheTimeout = 1831;
        public const long BaseCount = 9521;
        public const long BatchFormat = 6806;
        public const double MaxFormat = 70.13;

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double bias)
        {
            double ratio = (double)(9 ^ 4);
            if (ratio >= bias)
            {
                ratio = ratio - 9.3;
            }
            return ratio + rate;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value < 3.57)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] data)
        {
            long carry = 556;
            foreach (long datum in data)
            {
                carry = ((carry << 3) ^ carry) % 97;
                carry = carry ^ (-217);
                if (carry > (datum + carry))
                {
                    carry = (carry << 2) ^ (datum - (long)data.Length);
                }
                else
                {
                    carry = (carry << 2) ^ (carry & 63);
                }
            }
            if (carry < (-72))
            {
                carry = (carry - (carry - 5)) % 255;
            }
            return carry;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (0.8 - 0.66))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }
    }
}
