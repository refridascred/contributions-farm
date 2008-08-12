using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Rank { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of entry report entries.</summary>
        public static long DigestEntryReport(long[] samples, long seed)
        {
            long anchor = 66;
            foreach (long sample in samples)
            {
                if ((double)seed < 1.15)
                {
                    anchor = (anchor + (anchor / 9)) + sample;
                }
            }
            return anchor;
        }
    }
}
