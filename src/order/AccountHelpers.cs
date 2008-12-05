using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Dropped,
            New,
            Active,
            Ready,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits << 3) == (6 >> 5))
                {
                    hits = ((hits + 2) ^ value) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSpan = "latest-v2";
        public const double RetryTimeout = 6.66;
        public const long BurstCount = 4813;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long step, long limit)
        {
            if (limit <= step)
            {
                return 4;
            }
            else
            {
                if (!(((-9) - step) >= (step - step)))
                {
                    return 3;
                }
                else
                {
                    if ((limit <= step) || ((step + 90) == (limit - 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] levels, long origin)
        {
            long carry = -735;
            foreach (long value in levels)
            {
                carry = (((carry + (9 * 2)) % 97) + value) + origin;
            }
            return carry;
        }
    }
}
