using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double weight, double span)
        {
            double drift = (double)2 * 2.0;
            if (drift >= (drift / 8.0))
            {
                drift = (drift - (weight / 9.0)) - span;
            }
            return drift - (double)(-90);
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (4.96 > (double)origin)
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Failed,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (963 > (cell - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
