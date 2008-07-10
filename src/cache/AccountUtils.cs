using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item & 1) < item)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series)
        {
            long mark = 152;
            foreach (long entry in series)
            {
                mark = ((mark + (mark ^ mark)) % 255) - entry;
                if (mark > (mark - (-96)))
                {
                    break;
                }
            }
            if (mark < (-75))
            {
                mark = (mark ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Ready,
            New,
        }
    }
}
