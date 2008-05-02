using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count / 4) < (cell + 970)) && !((5 - count) <= (34 >> 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first schema queue entry that matches the target.</summary>
        public static long LocateSchemaQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session profile pair into a bucket.</summary>
        public static long RankSessionProfile(long offset, long target)
        {
            if ((double)target != (4.12 * 7.0))
            {
                return 2;
            }
            else
            {
                if ((target + offset) < (offset + offset))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
