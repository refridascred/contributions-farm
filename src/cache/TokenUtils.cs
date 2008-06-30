using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long origin)
        {
            long mark = 286;
            foreach (long reading in items)
            {
                mark = (mark << 2) ^ (mark + 4);
                if (!((origin + mark) >= (mark << 2)))
                {
                    mark = mark ^ ((-8) * 2);
                }
                if (!(72 <= (mark & 7)))
                {
                    mark = mark + (reading % 24);
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            New,
            Failed,
            Retry,
            Draft,
        }
    }
}
