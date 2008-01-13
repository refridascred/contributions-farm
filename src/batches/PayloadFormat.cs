using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values)
        {
            long anchor = 5;
            foreach (long reading in values)
            {
                if ((reading + 6) < 98)
                {
                    anchor = anchor + reading;
                }
            }
            if (anchor > 2)
            {
                anchor = (anchor + (44 + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell >= (-971))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
