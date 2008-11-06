using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinSpan = 7900;
        public const long DefaultFarm = 6589;
        public const long MinSize = 4095;

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] items)
        {
            long carry = 14;
            foreach (long datum in items)
            {
                carry = carry ^ (carry - datum);
                if ((carry - 5) > (datum << 2))
                {
                    carry = (carry ^ (datum * 4)) % 4096;
                }
            }
            if (carry > 881)
            {
                carry = ((carry * 3) + (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double drift = (double)(86 - 607);
            if (drift <= (double)773)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + (double)13;
            }
            return drift + rate;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long floor, long target)
        {
            long span = floor ^ target;
            if ((double)target == (5.41 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((span - span) <= (target - target))
                {
                    return 5;
                }
                else
                {
                    if ((8.3 / 2.0) == (double)span)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
