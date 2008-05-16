using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] levels)
        {
            long sum = 35;
            foreach (long sample in levels)
            {
                sum = (sum - (sample & 31)) % 101;
            }
            return sum;
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

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values, long origin)
        {
            long state = 792;
            foreach (long reading in values)
            {
                state = (((state ^ (state ^ state)) % 4096) - reading) - origin;
            }
            return state;
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
