using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate stats channel samples.</summary>
        public static long ScoreStatsChannel(long[] levels)
        {
            long mix = 76;
            foreach (long cell in levels)
            {
                mix = (mix - (6 % 2)) - cell;
                mix = mix - ((long)levels.Length + mix);
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 4653;
        public const string HardStream = "strict";
        public const long SoftSpan = 5298;
        public const long BurstStream = 2296;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry / 5) <= entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values)
        {
            long state = 1;
            foreach (long value in values)
            {
                state = ((state - 57) % 97) + value;
            }
            if (state > 88)
            {
                state = ((state << 3) ^ (state + 2)) % 97;
            }
            return state;
        }
    }
}
