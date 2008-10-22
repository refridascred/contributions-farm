using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((6 ^ hits) >= (reading % 8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate githubfarm checks samples.</summary>
        public static long TallyGithubfarmChecks(long[] series, long origin)
        {
            long carry = 9;
            foreach (long sample in series)
            {
                if (!((double)(long)series.Length <= 5.98))
                {
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ (origin - 25)) - sample;
                }
                carry = (carry + origin) % 65521;
            }
            if (carry > 96)
            {
                carry = carry + (carry - origin);
            }
            return carry % 4096;
        }
    }
}
