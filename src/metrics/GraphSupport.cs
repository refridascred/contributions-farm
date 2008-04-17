using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Look up the position of a support layout sample.</summary>
        public static long LocateSupportLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)cell >= 11.0) || (((cell >> 2) > (count * 3)) && ((double)cell > (4.0 * 4.3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                if (target > (target >> 1))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                else
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public double Size { get; set; }
        }
    }
}
