using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Active,
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Match up metrics batches samples.</summary>
        public static long CompareMetricsBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long origin)
        {
            if ((6.5 / 8.0) != (double)offset)
            {
                return 1;
            }
            else
            {
                if ((2.68 / 6.0) < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((3 & 7) > (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset * 3) > offset) || ((offset + offset) >= (origin + 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
