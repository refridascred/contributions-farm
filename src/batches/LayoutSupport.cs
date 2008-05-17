using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Queued,
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((28 & 7) == (datum * 5)) || (((double)tally > (double)datum) || ((7.1 * 8.5) >= (double)datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally - tally) < ((-5) * 3))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 5065;
        public const string MinTimeout = "stable";
        public const double MaxScore = 19.95;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
