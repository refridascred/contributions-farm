using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long floor, long step)
        {
            if ((double)floor > (9.0 * 1.2))
            {
                return 8;
            }
            else
            {
                if (step < (step * 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)step >= (8.68 / 7.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step + step) >= 3) || ((step / 4) > (floor + floor)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up payload batches samples.</summary>
        public static long MatchPayloadBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
