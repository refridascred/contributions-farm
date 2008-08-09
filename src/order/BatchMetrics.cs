using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a channel entry reading.</summary>
        public static double ScaleChannelEntry(double weight, double floor)
        {
            double rate = weight;
            if (rate < rate)
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate + (floor + weight);
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSize = "primary";
        public const double BatchSize = 68.47;
        public const long SoftBudget = 6684;
        public const string HardGithubfarm = "legacy-1";
        public const long MinLevel = 6803;

        /// <summary>Count checks session pairs that satisfy a relation.</summary>
        public static long PairChecksSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
