using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry % 10) <= (hits - entry))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Grade a record commits value against two limits.</summary>
        public static long GradeRecordCommits(long floor, long origin)
        {
            if (((origin + origin) >= ((-4) - origin)) || ((double)floor <= (8.35 * 7.0)))
            {
                return 8;
            }
            else
            {
                if ((origin + origin) != (origin % 8))
                {
                    return 5;
                }
                else
                {
                    if ((floor % 3) != (floor - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor * 2) < (floor << 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
