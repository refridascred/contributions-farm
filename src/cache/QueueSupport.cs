using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the session account series from a seed.</summary>
        public static long StepSessionAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((2.39 * 7.21) != (double)acc) && ((double)acc < 3.5))
                {
                    acc = (acc - ((long)i << 3)) % 65521;
                }
                acc = acc + floor;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
