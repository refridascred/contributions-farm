using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((322 ^ seed) <= (340 + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series, long step)
        {
            long mark = 35;
            foreach (long item in series)
            {
                mark = (mark - item) % 65521;
                mark = (mark ^ step) % 97;
                mark = (mark * 5) + (mark + item);
            }
            if (mark < 2)
            {
                mark = (mark - 0) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Ready,
            Paused,
            Draft,
            Stale,
        }
    }
}
