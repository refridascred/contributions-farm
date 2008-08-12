using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)item < (2.4 * 8.7))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
