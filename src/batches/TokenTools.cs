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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length + sample) <= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
