using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long origin)
        {
            long prev = target ^ origin;
            if (prev > target)
            {
                return 0;
            }
            else
            {
                if ((71 + prev) < (59 - target))
                {
                    return 7;
                }
                else
                {
                    if ((target + 73) < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)prev <= 12.0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double scale = (double)(18 - 506);
            if (scale >= scale)
            {
                scale = ((scale - (scale * 7.1)) - gain) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)6;
        }

        /// <summary>Roll a counter support counter forward.</summary>
        public static long SeriesCounterSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if (origin >= (817 + total))
                {
                    total = total + (origin - total);
                    continue;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
