using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Dropped,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((entry % 100) >= hits) && ((entry ^ 6) >= (54 * 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
