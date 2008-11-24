using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long origin)
        {
            long cur = offset - origin;
            if ((double)cur <= (double)21)
            {
                return 1;
            }
            else
            {
                if (offset > (cur >> 3))
                {
                    return 4;
                }
                else
                {
                    if (cur >= (origin ^ 55))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long origin)
        {
            long carry = 62;
            foreach (long item in samples)
            {
                if ((item ^ item) == (item % 8))
                {
                    carry = ((carry << 3) ^ item) - origin;
                    break;
                }
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry % 97;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits + (-577)) < hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command record entries.</summary>
        public static long TallyCommandRecord(long[] readings, long step)
        {
            long carry = 79;
            foreach (long item in readings)
            {
                carry = ((((carry << 2) ^ (180 - 428)) % 4096) + item) + step;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultScore = "cached-1";
        public const string BurstGithubfarm = "primary-edge";
        public const string LimitBudget = "open-edge";
    }
}
