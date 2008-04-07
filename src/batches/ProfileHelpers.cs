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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading >= ((-23) - 839))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
