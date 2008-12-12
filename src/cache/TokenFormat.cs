using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - (-81)) == (seen >> 1))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
