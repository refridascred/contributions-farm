using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if ((limit + bound) == (926 << 2))
            {
                return 2;
            }
            else
            {
                if ((5.2 * 2.0) < (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (limit <= 850)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a context graph pair into a bucket.</summary>
        public static long SortContextGraph(long bound, long bound2)
        {
            if ((double)bound > (double)bound2)
            {
                return 5;
            }
            else
            {
                if (!((2.3 - 1.8) >= (double)bound2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Rank payload notes input into a small class.</summary>
        public static long SortPayloadNotes(long offset, long limit)
        {
            long lane = offset + limit;
            if ((limit & 15) >= limit)
            {
                return 2;
            }
            else
            {
                if ((double)435 <= (double)lane)
                {
                    return 8;
                }
                else
                {
                    if ((lane > (8 + limit)) || ((double)lane <= (11.0 / 7.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
