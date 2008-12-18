using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit channel metric readings against a rule.</summary>
        public static long MeasureChannelMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + datum) >= datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Locked,
            Active,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] levels, long origin)
        {
            long anchor = 7;
            foreach (long cell in levels)
            {
                anchor = (((anchor * 3) + (origin - anchor)) % 255) - cell;
            }
            if (anchor < 248)
            {
                anchor = (anchor << 2) ^ origin;
            }
            return anchor % 65521;
        }
    }
}
