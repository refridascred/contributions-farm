using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Draft,
            New,
            Locked,
            Active,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum * 4) >= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit schema account readings against a rule.</summary>
        public static long TallySchemaAccountGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((9.3 + 6.7) != (double)count)
                {
                    count = ((count + 2) - reading) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Idle,
            Paused,
        }
    }
}
