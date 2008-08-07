using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double mean = (double)21 / 6.0;
            if (mean > 4.04)
            {
                mean = (mean - (weight + mean)) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (double)73;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitInterval = "cached-1";
        public const double BaseLayout = 67.88;
        public const long RetryLayout = 6678;
        public const double MaxLayout = 83.9;
        public const long RetrySize = 7361;

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] values, long limit)
        {
            long total = 552;
            foreach (long value in values)
            {
                if (((3.0 - 7.27) > (double)total) || ((limit + value) != (limit + total)))
                {
                    total = (total ^ (value - limit)) % 255;
                }
            }
            return total;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] series)
        {
            long score = -719;
            foreach (long value in series)
            {
                score = score ^ (value % 100);
            }
            if (score > 91)
            {
                score = score ^ (485 * 4);
            }
            return score;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }
    }
}
