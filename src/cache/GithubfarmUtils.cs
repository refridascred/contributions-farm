using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of session checks entries.</summary>
        public static long FoldSessionChecks(long[] levels)
        {
            long carry = 8;
            foreach (long sample in levels)
            {
                if (7 < (carry % 64))
                {
                    carry = (((carry * 5) + carry) % 97) + sample;
                }
                else
                {
                    carry = carry ^ 664;
                }
            }
            if (carry > 6)
            {
                carry = ((carry << 3) ^ (carry << 3)) % 255;
            }
            return carry;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((entry % 12) < (hits / 7)) && (((long)levels.Length + hits) == (hits * 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            New,
            Active,
            Paused,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
