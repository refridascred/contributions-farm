using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Queued,
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels, long offset)
        {
            long anchor = 383;
            foreach (long reading in levels)
            {
                if ((anchor * 4) == (reading + offset))
                {
                    anchor = (anchor ^ (anchor << 1)) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long target)
        {
            if (seed <= (seed + seed))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (0.33 / 2.0))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
