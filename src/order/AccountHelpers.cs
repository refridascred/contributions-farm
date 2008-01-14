using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of token filter entries.</summary>
        public static long TallyTokenFilter(long[] levels, long offset)
        {
            long sum = 1;
            foreach (long entry in levels)
            {
                if ((sum * 3) <= (entry + sum))
                {
                    sum = ((sum << 2) ^ (entry % 100)) % 65521;
                    sum = (sum + (entry + sum)) % 97;
                }
                if ((offset >> 3) != (sum + sum))
                {
                    sum = (sum + (sum + (-87))) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data, long seed)
        {
            long score = 3;
            foreach (long reading in data)
            {
                if ((reading % 8) >= (0 & 127))
                {
                    score = ((score + (972 << 2)) % 101) - seed;
                }
                else
                {
                    score = (score * 2) + ((long)data.Length - 56);
                }
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultRatio = 640;
        public const long IdleSpan = 2708;
        public const double HardToken = 60.12;
        public const long LimitSpan = 610;
    }
}
