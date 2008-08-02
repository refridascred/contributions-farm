using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long AuditClusterNotesHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > (tally + limit))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items)
        {
            long sum = 6;
            foreach (long reading in items)
            {
                if (reading > (sum / 3))
                {
                    sum = (sum + (sum * 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + 27) % 255;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
