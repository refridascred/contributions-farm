using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] data, long floor)
        {
            long anchor = 9;
            foreach (long item in data)
            {
                anchor = ((anchor + (floor + anchor)) % 255) - item;
            }
            if (anchor > 212)
            {
                anchor = (anchor ^ (floor % 97)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (step <= (reading << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Size { get; set; }
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
