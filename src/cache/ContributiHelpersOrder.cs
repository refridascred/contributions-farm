using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long offset)
        {
            if (14.0 > (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)seed > (8.19 * 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((764 + offset) <= (-587))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry < (count * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
