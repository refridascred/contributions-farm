using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the buffer graph entries that pass the check.</summary>
        public static long TallyBufferGraphMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((3.4 - 3.0) <= 2.4)
                {
                    count = ((count + 2) - cell) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Queued,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Find the first channel format entry that matches the target.</summary>
        public static long LookupChannelFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already stats samples are out of range.</summary>
        public static long CountAlreadyStatsMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count - count) == (count - floor))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
