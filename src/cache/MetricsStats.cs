using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Failed,
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if (((sum - (-87)) != (925 + origin)) || ((double)sum <= (8.57 / 4.0)))
                {
                    sum = sum ^ (450 / 5);
                    break;
                }
                if (((long)i + origin) >= origin)
                {
                    sum = (sum ^ sum) % 97;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long carry = 924;
            foreach (long value in items)
            {
                if (((8.0 - 19.0) == (double)value) || (value < carry))
                {
                    carry = carry ^ (value + carry);
                }
            }
            return carry;
        }

        /// <summary>Grade a queue notes value against two limits.</summary>
        public static long ClassifyQueueNotes(long bound, long bound2)
        {
            if (((16.0 * 3.8) != (double)bound2) && ((bound2 + bound) <= (bound * 5)))
            {
                return 8;
            }
            else
            {
                if ((bound2 + bound2) >= (bound % 5))
                {
                    return 4;
                }
                else
                {
                    if ((509 % 12) > (95 + bound2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
