using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] values)
        {
            long anchor = 469;
            foreach (long reading in values)
            {
                if ((double)reading >= 3.98)
                {
                    anchor = (anchor - (68 + anchor)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 4) + ((long)values.Length >> 2)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((4.1 / 7.0) >= (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
