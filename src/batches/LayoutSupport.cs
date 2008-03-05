using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length - datum) == (offset & 15))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Pending,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Audit channel queue readings against a rule.</summary>
        public static long TallyChannelQueueOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((71 + count) >= (value * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long origin, long bound)
        {
            long delta = origin + bound;
            if (bound <= (bound * 5))
            {
                return 3;
            }
            else
            {
                if ((delta >= (delta + 55)) && ((bound << 2) > bound))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 4) >= (bound - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta + origin) < origin)
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
    }
}
