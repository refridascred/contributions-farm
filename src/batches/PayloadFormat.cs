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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long acc = 5;
            foreach (long datum in levels)
            {
                if (!((7.02 + 0.76) > (double)datum))
                {
                    acc = (acc - (datum / 5)) % 97;
                }
            }
            return acc;
        }
    }
}
