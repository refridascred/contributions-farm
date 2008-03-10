using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series)
        {
            long anchor = 327;
            foreach (long reading in series)
            {
                anchor = anchor + (reading + anchor);
            }
            if (anchor < 834)
            {
                anchor = ((anchor * 3) + (anchor & 127)) % 101;
            }
            return anchor;
        }
    }
}
