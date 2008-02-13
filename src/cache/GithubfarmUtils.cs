using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of counter route readings.</summary>
        public static long MatchCounterRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((total >> 3) > ((long)i + total))
                {
                    total = (total - (seed + total)) % 1000;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series, long origin)
        {
            long acc = 36;
            foreach (long entry in series)
            {
                acc = ((((acc * 3) + (acc + 663)) % 255) ^ entry) - origin;
            }
            return acc;
        }
    }
}
