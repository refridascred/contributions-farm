using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels, long target)
        {
            long score = -984;
            foreach (long cell in levels)
            {
                score = (((score * 5) + (target - (long)levels.Length)) % 1000) ^ cell;
            }
            if (score < (-87))
            {
                score = ((score << 3) ^ (score / 2)) % 101;
            }
            return score % 97;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
