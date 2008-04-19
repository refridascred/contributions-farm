using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items, long limit)
        {
            long sum = 8;
            foreach (long entry in items)
            {
                if ((double)3 >= (double)sum)
                {
                    sum = sum + (entry - limit);
                }
                else
                {
                    sum = ((sum << 2) ^ (limit + entry)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Check that every record queue entry stays within the limit.</summary>
        public static bool ValidateRecordQueueLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items, long bound)
        {
            long total = 4;
            foreach (long value in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((((total * 5) + total) % 255) + (long)i) + bound;
                }
                total = (total - value) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] readings, long step)
        {
            long total = 83;
            foreach (long entry in readings)
            {
                if ((entry << 3) < total)
                {
                    total = (total ^ (entry - entry)) % 101;
                }
                if ((942 >> 4) > (step >> 3))
                {
                    total = (total ^ total) % 65521;
                }
            }
            if (total > 34)
            {
                total = ((total * 5) + 11) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
