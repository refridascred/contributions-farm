using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            New,
            Synced,
            Draft,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream checks entries that pass the check.</summary>
        public static long CountStreamChecksGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((3.0 - 4.54) == (double)matches) || ((matches + 577) <= (matches & 7)))
                {
                    matches = ((matches + 1) ^ cell) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many format account samples are out of range.</summary>
        public static long AuditFormatAccountOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((9.15 + 4.23) < (double)matches) || (((double)item <= 15.0) && ((double)item >= (1.96 + 3.0))))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }
    }
}
