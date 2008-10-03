using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (647 <= (entry << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long origin)
        {
            long bound = limit + origin;
            if (((4 - origin) <= (limit ^ bound)) || ((6.51 + 1.63) <= (double)limit))
            {
                return 3;
            }
            else
            {
                if (((limit + origin) > (243 + limit)) && ((double)bound < (18.0 / 9.0)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((3.63 * 7.0) >= (double)item)
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }
    }
}
