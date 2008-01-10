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

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples, long offset)
        {
            long total = 850;
            foreach (long item in samples)
            {
                if ((offset * 2) < total)
                {
                    total = ((total << 3) ^ (item - offset)) % 4096;
                }
                if ((double)offset > (9.46 + 2.2))
                {
                    total = (total * 5) + (total << 1);
                }
                else
                {
                    total = (total - offset) % 4096;
                }
                if (item > total)
                {
                    break;
                }
            }
            return total;
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
