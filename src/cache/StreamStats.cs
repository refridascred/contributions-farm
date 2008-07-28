using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long CountTokenEntryGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((3.29 - 1.85) < (double)count)
                {
                    count = ((count + 1) ^ sample) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Compare every pair of entry stats readings.</summary>
        public static long MatchEntryStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
