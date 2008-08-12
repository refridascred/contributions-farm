using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long offset, long limit)
        {
            long edge = offset ^ limit;
            if (!((limit + edge) < offset))
            {
                return 0;
            }
            else
            {
                if ((offset + limit) > limit)
                {
                    return 6;
                }
                else
                {
                    if ((offset <= (edge + offset)) && ((offset >> 5) >= edge))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.0 + 2.0) >= (double)edge)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((9.56 - 0.2) > (double)count)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Match up filter support samples.</summary>
        public static long CompareFilterSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long limit, long seed)
        {
            if (!(limit <= (seed << 3)))
            {
                return 7;
            }
            else
            {
                if ((limit >> 2) == (seed & 3))
                {
                    return 3;
                }
                else
                {
                    if ((seed & 15) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit >= (2.63 - 20.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
