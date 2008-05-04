using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double bias2)
        {
            double weight = bias2;
            if (weight < (double)(-43))
            {
                weight = (weight - weight) - bias;
            }
            return weight + (double)29;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + matches) == ((-1) - matches))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }
    }
}
