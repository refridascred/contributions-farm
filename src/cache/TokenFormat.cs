using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((seen >> 5) > (cell / 4)))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the profile commits entries that pass the check.</summary>
        public static long MeasureProfileCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item == (9.6 * 12.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
