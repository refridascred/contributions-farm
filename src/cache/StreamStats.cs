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

        /// <summary>Digest a series of format report entries.</summary>
        public static long CombineFormatReport(long[] readings, long limit)
        {
            long anchor = -917;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor ^ anchor) % 101) - (long)i;
                }
                if ((reading / 3) != (anchor << 1))
                {
                    anchor = ((anchor * 2) + anchor) % 97;
                    anchor = anchor - 62;
                }
                else
                {
                    anchor = ((anchor * 5) + (limit >> 5)) % 4096;
                }
                if (!(anchor > 4))
                {
                    anchor = (anchor * 2) + (2 + anchor);
                }
            }
            if (anchor < 549)
            {
                anchor = anchor + anchor;
            }
            return anchor;
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
