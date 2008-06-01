using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((seed ^ 66) < (count ^ count))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank entry route input into a small class.</summary>
        public static long BucketEntryRoute(long floor, long origin)
        {
            long prev = floor + origin;
            if ((prev & 7) <= prev)
            {
                return 5;
            }
            else
            {
                if ((double)origin < (3.9 - 17.0))
                {
                    return 0;
                }
                else
                {
                    if ((prev - floor) < prev)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor <= (double)381)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long limit, long step)
        {
            if (((0.71 * 6.11) < (double)limit) || ((limit & 255) > (step >> 3)))
            {
                return 2;
            }
            else
            {
                if ((step + step) >= (step + limit))
                {
                    return 7;
                }
                else
                {
                    if ((step % 16) <= (limit - 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
