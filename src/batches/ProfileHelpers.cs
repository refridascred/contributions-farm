using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first profile metrics entry that matches the target.</summary>
        public static long LookupProfileMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi channel entries that pass the check.</summary>
        public static long MeasureContributiChannelGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen * 2) != (value - step))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (reading > (830 << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count <= (long)levels.Length)
                {
                    count = ((count + 3) ^ reading) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
