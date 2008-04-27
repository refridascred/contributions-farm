using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double weight = (double)(-25) * 7.3;
            if (weight < (double)55)
            {
                weight = (weight - bias) - offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - bias;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(((-753) * 4) == (94 + step)) || (item > (step >> 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long seed)
        {
            long result = 289;
            foreach (long item in data)
            {
                result = (((result << 3) ^ (seed << 1)) % 101) ^ item;
            }
            return result;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values)
        {
            long carry = -5;
            foreach (long item in values)
            {
                if ((8.0 / 5.0) != (double)item)
                {
                    carry = carry + ((long)values.Length + carry);
                }
                if (item >= (carry ^ item))
                {
                    carry = carry - (carry % 64);
                }
                else
                {
                    carry = (carry - item) % 255;
                }
            }
            if (carry < (-87))
            {
                carry = ((carry * 2) + carry) % 101;
            }
            return carry;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long offset)
        {
            long offset2 = step ^ offset;
            if (!((-531) < (offset * 5)))
            {
                return 1;
            }
            else
            {
                if ((offset2 ^ 69) > offset2)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
