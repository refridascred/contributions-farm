using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up graph batch samples.</summary>
        public static long PairGraphBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Idle,
            Active,
            New,
            Retry,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long floor, long step)
        {
            if (((double)floor != (double)step) && ((2.2 * 12.0) != (double)step))
            {
                return 8;
            }
            else
            {
                if ((step - step) >= (step + step))
                {
                    return 4;
                }
                else
                {
                    if (((floor ^ floor) > (step & 3)) && (floor >= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor < (floor >> 5)) && (149 <= step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
