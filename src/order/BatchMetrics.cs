using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long bound)
        {
            if ((target << 1) == (bound % 16))
            {
                return 1;
            }
            else
            {
                if ((target / 4) <= target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (1 >= (datum - target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long floor)
        {
            long sum = -1;
            foreach (long sample in items)
            {
                if ((floor ^ 80) < floor)
                {
                    sum = (sum ^ sample) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double weight = bias;
            if (weight < 1.99)
            {
                weight = (weight - (bias - weight)) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (0.92 * 5.0);
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Done,
            Stale,
            Failed,
            Retry,
        }
    }
}
