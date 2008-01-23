using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long seed)
        {
            if ((seed * 2) >= (bound + seed))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) == (bound << 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] levels)
        {
            long anchor = 0;
            foreach (long sample in levels)
            {
                if (!(anchor > (sample % 16)))
                {
                    anchor = (anchor ^ (anchor << 1)) % 255;
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            if (anchor < 558)
            {
                anchor = anchor + (anchor << 2);
            }
            return anchor % 97;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Idle,
            Synced,
            Dropped,
            Active,
        }
    }
}
