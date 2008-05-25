using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (target - 1)) % 97;
                if (target > (sum - (long)i))
                {
                    sum = (sum << 2) ^ 585;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value > matches)
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Derive the next githubfarm channel value from a seed.</summary>
        public static long IterateGithubfarmChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally - tally) == (offset >> 1))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
