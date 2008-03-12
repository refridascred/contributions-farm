using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every route notes entry stays within the limit.</summary>
        public static bool GuardRouteNotesBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many context cache samples are out of range.</summary>
        public static long TallyContextCacheOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally < (55 + tally)) || (81 < (tally >> 4)))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] values, long offset)
        {
            long anchor = 6;
            foreach (long datum in values)
            {
                if ((6 < offset) && ((double)offset != (double)datum))
                {
                    anchor = (anchor << 3) ^ (offset + offset);
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor * 5) + offset;
            }
            return anchor % 1000;
        }
    }
}
