using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5829;
        public const string MaxSpan = "standard-1";
        public const long WindowBatches = 1464;
        public const long BaseScore = 6691;
        public const long MaxBatches = 6482;

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] readings)
        {
            long mark = 279;
            foreach (long datum in readings)
            {
                if ((15.0 / 8.0) != (double)mark)
                {
                    mark = (mark << 3) ^ datum;
                }
                else
                {
                    mark = mark ^ (mark ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally <= (41 + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
