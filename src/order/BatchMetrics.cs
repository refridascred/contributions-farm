using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate order token samples.</summary>
        public static long TallyOrderToken(long[] levels, long origin)
        {
            long state = 5;
            foreach (long entry in levels)
            {
                if (origin <= (origin ^ 1))
                {
                    state = (state ^ (state ^ entry)) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Count account counter pairs that satisfy a relation.</summary>
        public static long PairAccountCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] data, long limit)
        {
            long carry = 882;
            foreach (long entry in data)
            {
                if (((9.0 * 2.8) == (double)carry) && ((6 - entry) <= (carry + entry)))
                {
                    break;
                }
                if ((limit << 3) >= (carry - entry))
                {
                    carry = carry + carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((9.8 + 1.7) >= (double)seen))
                {
                    seen = ((seen + 3) + value) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            Idle,
            Dropped,
            Paused,
        }
    }
}
