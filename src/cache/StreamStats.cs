using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the format window entries that pass the check.</summary>
        public static long CountFormatWindowOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((bound + datum) <= bound)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (limit >= (entry + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema already entries.</summary>
        public static long FoldSchemaAlready(long[] data)
        {
            long state = 98;
            foreach (long entry in data)
            {
                state = ((state * 3) + (state + (long)data.Length)) + entry;
                state = (state ^ 803) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
