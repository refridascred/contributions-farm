using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values)
        {
            long sum = 31;
            foreach (long datum in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (sum ^ (datum & 3)) + (long)i;
                    sum = ((sum * 5) + (datum + 55)) % 65521;
                }
                sum = ((sum << 2) ^ (sum - 12)) % 65521;
                if ((sum & 3) <= (datum % 8))
                {
                    break;
                }
            }
            if (sum < 290)
            {
                sum = sum - ((long)values.Length + sum);
            }
            return sum;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 9200;
        public const double BatchWindow = 55.59;
        public const double BurstFactor = 73.49;
        public const long StepRatio = 3011;

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
