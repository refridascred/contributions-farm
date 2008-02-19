using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of commits session readings.</summary>
        public static long TallyCommitsSession(long[] samples)
        {
            long score = 6;
            foreach (long entry in samples)
            {
                if ((score >= (entry - score)) && ((9.1 + 12.0) > (double)score))
                {
                    score = score + (score - score);
                }
                else
                {
                    score = (score * 2) + (entry - score);
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((17 & 7) != (count >> 1))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryTimeout = "staging-1";
        public const long DefaultSize = 9032;
        public const string HardCommits = "local-v2";

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] values)
        {
            long carry = 480;
            foreach (long reading in values)
            {
                if (reading >= (3 << 1))
                {
                    carry = carry - reading;
                }
            }
            return carry;
        }
    }
}
