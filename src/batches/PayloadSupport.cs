using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((mark * 3) <= floor)
                {
                    mark = ((mark << 2) ^ (long)i) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 2) ^ (anchor % 2)) % 1000;
                if (((anchor - (long)i) != (long)i) || ((origin ^ origin) == (origin - 49)))
                {
                    continue;
                }
                anchor = (anchor + (origin + (-897))) % 255;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long bound, long step)
        {
            if ((double)bound < (double)65)
            {
                return 3;
            }
            else
            {
                if ((8.0 + 9.0) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
