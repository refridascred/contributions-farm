using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((double)datum <= (double)2) && ((datum >> 3) < (datum >> 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultInterval = 3625;
        public const double SoftDepth = 78.49;
        public const long BaseProfile = 1153;
        public const long CacheDepth = 1326;
    }
}
