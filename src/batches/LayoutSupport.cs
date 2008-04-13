using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Stale,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepTimeout = "latest-edge";
        public const string BaseRatio = "standard-1";
        public const string MaxLevel = "legacy-1";

        /// <summary>Measure how many format batch samples are out of range.</summary>
        public static long TallyFormatBatchHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (floor < ((long)levels.Length - tally))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long TallyEntryAccountHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((3.0 - 9.0) == (double)entry)
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit stream order readings against a rule.</summary>
        public static long CountStreamOrderHits(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((target & 1) < count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
