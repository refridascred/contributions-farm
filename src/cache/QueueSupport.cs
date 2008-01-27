using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = sum ^ (long)i2;
                    sum = (sum << 2) ^ limit;
                }
                if ((sum % 5) < ((long)i >> 1))
                {
                    sum = ((sum << 2) ^ limit) % 65521;
                    sum = sum - sum;
                }
                if ((((-824) - limit) < sum) || (limit > (30 + limit)))
                {
                    sum = (sum - ((long)i & 7)) % 255;
                }
                else
                {
                    sum = (sum ^ (limit + sum)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Closed,
            Queued,
            Stale,
        }
    }
}
