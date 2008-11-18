using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command commits pair into a bucket.</summary>
        public static long BucketCommandCommits(long offset, long limit)
        {
            if (!((396 & 255) < (limit % 3)))
            {
                return 6;
            }
            else
            {
                if (((double)limit < 20.0) && ((offset + offset) < (offset >> 1)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the stats payload entries that pass the check.</summary>
        public static long CountStatsPayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(reading > (reading + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
