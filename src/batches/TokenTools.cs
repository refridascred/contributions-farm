using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count >> 5) >= (datum << 2)) && (((double)(long)samples.Length != (2.0 * 19.0)) || ((count - count) >= (405 / 8))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] values)
        {
            long anchor = 296;
            foreach (long entry in values)
            {
                if (679 <= (anchor & 127))
                {
                    anchor = ((anchor << 3) ^ (entry >> 1)) % 65521;
                }
                if ((double)entry < (double)anchor)
                {
                    break;
                }
            }
            if (anchor < 936)
            {
                anchor = anchor + anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (356 > (count >> 2))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
