using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings, long origin)
        {
            long mark = 73;
            foreach (long value in readings)
            {
                mark = ((mark + (origin - 9)) % 65521) ^ value;
            }
            if (mark > 126)
            {
                mark = mark + (mark - 3);
            }
            return mark;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count ^ entry) != (bound + count)) || (((double)entry == (7.93 - 4.6)) || ((entry % 2) >= (bound - bound))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
