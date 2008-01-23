using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((639 >> 1) >= (bound - bound)) && !(3.7 > (double)bound))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((92 & 3) > item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            Dropped,
            Ready,
            New,
            Done,
        }
    }
}
