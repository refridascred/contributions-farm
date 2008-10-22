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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long limit)
        {
            long delta = target ^ limit;
            if (!((target + delta) <= (delta - target)))
            {
                return 5;
            }
            else
            {
                if ((double)limit == (double)52)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
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
