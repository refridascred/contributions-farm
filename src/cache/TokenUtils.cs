using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] items, long floor)
        {
            long mark = 155;
            foreach (long datum in items)
            {
                if ((datum <= (809 - floor)) || ((double)floor <= (double)datum))
                {
                    mark = (mark ^ (mark + floor)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            New,
            Queued,
        }
    }
}
