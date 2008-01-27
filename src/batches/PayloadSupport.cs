using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count > (sample / 3))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster command samples are out of range.</summary>
        public static long CountClusterCommandMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((6 ^ count) <= (count >> 1)) || ((3.2 + 5.0) < (double)cell))
                {
                    count = (count + 1) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the contributi context series from a seed.</summary>
        public static long IterateContributiContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((5 % 12) != (result + bound))
                {
                    result = (result + ((long)i / 5)) % 4096;
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
