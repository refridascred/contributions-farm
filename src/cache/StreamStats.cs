using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(count <= (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long bound2)
        {
            long bound3 = bound - bound2;
            if ((1.41 * 6.8) >= (double)bound2)
            {
                return 8;
            }
            else
            {
                if ((bound - bound2) != (bound3 - bound3))
                {
                    return 1;
                }
                else
                {
                    if ((11.0 * 4.4) != (double)bound3)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - (double)1) + floor;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] values)
        {
            long mark = -6;
            foreach (long datum in values)
            {
                if (((double)datum != (3.8 + 7.88)) && (datum > mark))
                {
                    mark = (mark * 2) + (datum * 4);
                }
            }
            return mark % 4096;
        }
    }
}
