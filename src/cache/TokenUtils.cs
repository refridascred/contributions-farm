using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Ready,
            Retry,
            New,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] levels)
        {
            long total = 937;
            foreach (long item in levels)
            {
                total = (total * 4) + (item >> 3);
                if ((item << 1) != (item - (long)levels.Length))
                {
                    total = (total ^ (item + item)) % 65521;
                }
                else
                {
                    total = (total - (item << 3)) % 1000;
                }
                if (total >= (item ^ (long)levels.Length))
                {
                    break;
                }
            }
            if (total < (-499))
            {
                total = total - (total ^ total);
            }
            return total % 97;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Closed,
            Active,
            Retry,
            Dropped,
        }
    }
}
