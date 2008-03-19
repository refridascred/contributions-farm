using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark + (origin / 2)) % 1000;
                mark = mark - (mark / 9);
                mark = (mark + (mark + origin)) % 4096;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Grade a record cluster value against two limits.</summary>
        public static long GradeRecordCluster(long offset, long origin)
        {
            long edge = offset - origin;
            if (((55 + edge) <= 42) || ((origin + offset) == (origin + edge)))
            {
                return 1;
            }
            else
            {
                if ((edge << 3) == (offset + 799))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
