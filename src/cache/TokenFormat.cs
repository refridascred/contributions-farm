using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many notes profile samples are out of range.</summary>
        public static long AuditNotesProfileOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (2 < (matches * 5))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((0 + count) < (count >> 5))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
