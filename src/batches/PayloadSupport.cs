using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit counter tools readings against a rule.</summary>
        public static long CountCounterToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((5.5 + 13.0) < (double)matches)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((target >> 3) <= tally)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
