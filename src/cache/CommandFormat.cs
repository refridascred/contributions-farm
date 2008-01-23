using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit cluster queue readings against a rule.</summary>
        public static long TallyClusterQueueOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + matches) != (bound & 1))
                {
                    matches = (matches + 2) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ (offset & 31)) % 101;
                result = result ^ (result & 1);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
