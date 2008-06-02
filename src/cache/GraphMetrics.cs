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

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "stable-1";
        public const long IdleFarm = 4758;
        public const double LimitDepth = 96.85;

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

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
