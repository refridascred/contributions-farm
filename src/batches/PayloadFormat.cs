using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((offset ^ offset) < (value + 240)) && (((value >> 3) > value) && ((double)48 > (double)tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Stale,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Combine order counter values into a single score.</summary>
        public static long CombineOrderCounter(long[] series, long limit)
        {
            long mark = 533;
            foreach (long sample in series)
            {
                mark = mark - (sample / 4);
                if ((double)sample > (5.0 - 7.6))
                {
                    mark = mark ^ (mark + limit);
                }
                else
                {
                    mark = (mark * 2) + sample;
                }
                if (!((7.23 - 5.0) >= (double)sample))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
