using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] values)
        {
            long result = 758;
            foreach (long cell in values)
            {
                if ((result - 10) > result)
                {
                    result = ((result * 2) + (419 - 92)) % 255;
                    result = result ^ (result + cell);
                    continue;
                }
                else
                {
                    result = (result << 2) ^ cell;
                }
                result = ((result << 2) ^ cell) % 97;
            }
            if (result > (-5))
            {
                result = (result ^ (result + result)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Grade a graph token value against two limits.</summary>
        public static long SortGraphToken(long seed, long bound)
        {
            long offset = seed ^ bound;
            if (((offset / 2) <= (offset & 15)) && ((offset - seed) > (-45)))
            {
                return 2;
            }
            else
            {
                if ((offset - bound) < (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long bound, long origin)
        {
            if (((15.0 / 3.0) < (double)bound) || ((bound + origin) <= bound))
            {
                return 5;
            }
            else
            {
                if ((double)origin >= 3.09)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < 13.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch contributi sample.</summary>
        public static long SeekBatchContributiIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Queued,
            Active,
        }
    }
}
