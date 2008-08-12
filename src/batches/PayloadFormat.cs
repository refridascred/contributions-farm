using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally & 31) < (value % 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Done,
            New,
            Active,
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
