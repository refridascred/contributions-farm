using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((16 + matches) < (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a githubfarm report counter forward.</summary>
        public static long DeriveGithubfarmReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)seed == (9.3 - 8.5)))
                {
                    anchor = (anchor + (seed % 64)) % 1000;
                }
                anchor = anchor - ((long)i - 40);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank batch order input into a small class.</summary>
        public static long BucketBatchOrder(long target, long seed)
        {
            if (5.89 > (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)seed <= (2.53 * 13.0))
                {
                    return 2;
                }
                else
                {
                    if ((target - target) == (target % 10))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
