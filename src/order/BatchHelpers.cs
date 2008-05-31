using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the context metrics series from a seed.</summary>
        public static long IterateContextMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor ^ (long)i) % 101;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a stream support counter forward.</summary>
        public static long RollStreamSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long bound, long seed)
        {
            long span = bound ^ seed;
            if (((seed ^ bound) < (span % 16)) && (span > (span / 5)))
            {
                return 8;
            }
            else
            {
                if ((bound & 63) >= (856 << 3))
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) == (seed >> 2))
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
    }
}
