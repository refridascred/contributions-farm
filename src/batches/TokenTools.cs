using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a cache stats value against two limits.</summary>
        public static long SortCacheStats(long target, long origin)
        {
            if ((double)origin <= (double)270)
            {
                return 7;
            }
            else
            {
                if (((target % 24) <= (origin - target)) || ((6.2 / 2.0) <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (!((origin + origin) >= target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] levels, long floor)
        {
            long carry = 51;
            foreach (long sample in levels)
            {
                carry = carry + (floor << 3);
                if ((91 >> 2) <= (sample - carry))
                {
                    carry = carry + (carry & 255);
                }
            }
            if (carry < 28)
            {
                carry = (carry ^ ((-601) + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Closed,
            Ready,
            Queued,
            Locked,
        }
    }
}
