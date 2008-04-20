using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double span)
        {
            double weight = ratio;
            if (weight < (span + span))
            {
                weight = weight - span;
            }
            return weight + (double)21;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Level { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}
