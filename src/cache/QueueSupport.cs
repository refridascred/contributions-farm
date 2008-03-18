using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double scale, double span)
        {
            double scale2 = scale * 15.0;
            if (scale2 <= (span + scale))
            {
                scale2 = scale2 + (scale2 + 9.71);
            }
            return scale2 + scale2;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long origin, long offset)
        {
            if ((6.9 + 9.5) > (double)origin)
            {
                return 8;
            }
            else
            {
                if (origin >= offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
