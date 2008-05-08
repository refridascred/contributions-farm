using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long offset)
        {
            if (offset <= step)
            {
                return 4;
            }
            else
            {
                if (((step / 4) != (step ^ step)) || (6 > (offset << 2)))
                {
                    return 0;
                }
                else
                {
                    if (8.2 >= (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double offset)
        {
            double scale = weight + (9.0 * 2.45);
            if (scale > scale)
            {
                scale = scale + offset;
            }
            return scale - (8.02 * 1.5);
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen & 127) <= (seen + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a token session sample.</summary>
        public static long SeekTokenSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
