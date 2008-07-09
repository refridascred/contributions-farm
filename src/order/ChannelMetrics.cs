using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long limit)
        {
            long carry = 311;
            foreach (long datum in data)
            {
                carry = ((carry * 2) + (datum >> 4)) % 4096;
                if ((carry + 43) > limit)
                {
                    carry = (carry * 4) + 9;
                }
                if (((double)carry <= (1.26 * 5.1)) && ((limit + carry) <= 0))
                {
                    carry = (carry ^ (datum - carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Check that every already support entry stays within the limit.</summary>
        public static bool VerifyAlreadySupportLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
