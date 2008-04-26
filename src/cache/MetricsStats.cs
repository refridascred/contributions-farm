using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long acc = 20;
            foreach (long entry in levels)
            {
                if ((acc << 3) > (acc - acc))
                {
                    acc = (acc + (entry * 2)) % 101;
                    continue;
                }
                if (((57 ^ acc) > (acc + entry)) || ((double)acc > (double)entry))
                {
                    acc = ((acc * 3) + (entry - acc)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a contributi schema sample.</summary>
        public static long LookupContributiSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
