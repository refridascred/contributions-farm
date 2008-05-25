using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit queue farm readings against a rule.</summary>
        public static long MeasureQueueFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits - hits) <= (hits >> 5))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 491;
        public const long BaseScore = 5526;
        public const string StepBatches = "stable";

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

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
