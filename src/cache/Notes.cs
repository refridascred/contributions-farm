using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 3542;
        public const long LimitBudget = 1711;
        public const long IdleBuffer = 8287;
        public const string LimitBuffer = "local-edge";

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm entry samples are out of range.</summary>
        public static long CountFarmEntryMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((18.0 - 7.6) != (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (2.0 >= (double)matches)
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Queued,
            Pending,
            New,
            Stale,
        }
    }
}
