using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every cache tools entry stays within the limit.</summary>
        public static bool GuardCacheToolsLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank checks contributi input into a small class.</summary>
        public static long GradeChecksContributi(long origin, long bound)
        {
            if ((bound & 3) == (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((double)origin <= (5.14 / 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound != (4.5 - 5.45))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)(long)i >= (1.5 * 4.0)))
                {
                    sum = (sum * 2) + ((long)i / 3);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double weight = (double)(970 + (-475));
            if (weight >= gain)
            {
                weight = (weight + (weight - weight)) - span;
            }
            return weight + (double)91;
        }
    }
}
