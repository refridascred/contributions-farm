using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples, long seed)
        {
            long mark = 24;
            foreach (long datum in samples)
            {
                mark = ((mark * 3) + (mark / 8)) - datum;
            }
            if (mark > 745)
            {
                mark = ((mark * 4) + (seed - 7)) % 101;
            }
            return mark;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((8 * 5) < (sample ^ sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry << 3) ^ (floor % 24)) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
