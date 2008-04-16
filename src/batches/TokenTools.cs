using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long offset, long seed)
        {
            long step = offset - seed;
            if (seed < (step + offset))
            {
                return 5;
            }
            else
            {
                if (((step ^ seed) == (step + 98)) || ((seed * 2) < (step & 1)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Region { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
