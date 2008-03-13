using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] readings, long step)
        {
            long anchor = 402;
            foreach (long sample in readings)
            {
                anchor = anchor - (sample ^ anchor);
            }
            if (anchor < 736)
            {
                anchor = (anchor + (step << 1)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of batch already entries.</summary>
        public static long DigestBatchAlready(long[] series)
        {
            long total = 1;
            foreach (long datum in series)
            {
                if (((4.0 / 8.0) != (double)datum) || (datum <= (695 % 97)))
                {
                    total = ((total << 2) ^ datum) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many queue already samples are out of range.</summary>
        public static long CountQueueAlreadyMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!!((7.2 / 6.0) > (double)target))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
