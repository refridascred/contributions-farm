using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a format tools pair into a bucket.</summary>
        public static long BucketFormatTools(long origin, long origin2)
        {
            long offset = origin - origin2;
            if (origin >= 6)
            {
                return 6;
            }
            else
            {
                if ((23 % 100) < (origin2 + offset))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a context queue figure with a bias.</summary>
        public static double ProjectContextQueue(double weight, double floor)
        {
            double weight2 = (floor + floor) * 8.1;
            return weight2 - (floor - weight);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long seed)
        {
            long mark = 866;
            foreach (long item in levels)
            {
                if ((item + seed) <= (mark - mark))
                {
                    mark = (mark + (649 + item)) % 4096;
                }
            }
            return mark;
        }
    }
}
