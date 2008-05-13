using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the report notes entries that pass the check.</summary>
        public static long AuditReportNotesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)30 < (double)seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long anchor = 196;
            foreach (long entry in series)
            {
                if ((anchor << 1) <= (anchor & 15))
                {
                    anchor = (anchor ^ (652 / 4)) % 4096;
                }
                else
                {
                    anchor = (anchor + entry) % 101;
                }
                if (((double)anchor < (13.0 + 6.2)) || (anchor < (anchor + anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
