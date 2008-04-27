using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((92 ^ seed) <= (seed % 8))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
