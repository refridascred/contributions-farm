using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long floor, long origin)
        {
            long gap = floor + origin;
            if ((0.5 + 8.6) != (double)floor)
            {
                return 4;
            }
            else
            {
                if (((floor + floor) <= (2 - floor)) && ((floor % 24) <= origin))
                {
                    return 0;
                }
                else
                {
                    if (((floor & 63) > origin) && (1 >= (5 + gap)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
