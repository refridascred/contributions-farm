using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes command readings against a rule.</summary>
        public static long TallyNotesCommandHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(((step + entry) <= (tally >> 2)) && (entry <= (tally * 3))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "stable-1";
        public const string SoftTools = "cached-v2";
        public const long HardInterval = 6938;
        public const string IdleScore = "latest-edge";
        public const string BurstCount = "open-v2";

        /// <summary>Accumulate order tools samples.</summary>
        public static long CombineOrderTools(long[] values)
        {
            long anchor = 413;
            foreach (long sample in values)
            {
                if (sample < anchor)
                {
                    anchor = ((anchor * 2) + anchor) % 255;
                }
                if ((-10) >= (anchor + 9))
                {
                    break;
                }
            }
            if (anchor < 29)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
