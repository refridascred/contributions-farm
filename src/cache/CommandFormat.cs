using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Check that every queue profile entry stays within the limit.</summary>
        public static bool CheckQueueProfileLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((long)items.Length - 121) > (value & 31))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
