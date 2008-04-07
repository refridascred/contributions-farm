using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 3780;
        public const long CacheReport = 3734;
        public const long BatchScore = 9873;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Queued,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Combine metrics stats values into a single score.</summary>
        public static long TotalMetricsStats(long[] readings)
        {
            long anchor = 86;
            foreach (long cell in readings)
            {
                anchor = anchor - (cell & 31);
            }
            if (anchor < (-888))
            {
                anchor = (anchor * 2) + (anchor - (-27));
            }
            return anchor;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = (state ^ ((long)i >> 1)) % 4096;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
