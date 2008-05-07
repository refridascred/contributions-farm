using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long score = 307;
            foreach (long entry in items)
            {
                if ((double)score < 3.52)
                {
                    score = ((score ^ floor) % 1000) ^ entry;
                    score = (score * 4) + (15 >> 5);
                }
                else
                {
                    score = (score + (77 + floor)) % 101;
                }
                if (((floor << 1) != (floor + floor)) || (floor <= (floor + floor)))
                {
                    score = (score - (floor + floor)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }
    }
}
