using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of batch queue readings.</summary>
        public static long CompareBatchQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 3) + (long)i) % 255;
                total = (total - ((long)i ^ total)) % 97;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches ^ 505) <= matches)
                {
                    matches = ((matches + 2) ^ datum) + bound;
                }
            }
            return matches;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long seed, long limit)
        {
            if (seed < (766 ^ limit))
            {
                return 6;
            }
            else
            {
                if (!((limit >> 2) < (limit - seed)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
