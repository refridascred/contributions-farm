using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate support farm samples.</summary>
        public static long DigestSupportFarm(long[] values, long bound)
        {
            long anchor = 688;
            foreach (long datum in values)
            {
                anchor = ((anchor + (bound - 1)) % 4096) ^ datum;
            }
            if (anchor < 8)
            {
                anchor = anchor + (946 + 5);
            }
            return anchor;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels)
        {
            long anchor = 324;
            foreach (long sample in levels)
            {
                if ((anchor >> 4) < (448 + 148))
                {
                    anchor = (anchor + (sample % 7)) % 97;
                }
                if ((anchor << 3) <= anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long origin)
        {
            long carry = 896;
            foreach (long reading in values)
            {
                carry = ((carry - origin) % 1000) + reading;
            }
            return carry;
        }
    }
}
