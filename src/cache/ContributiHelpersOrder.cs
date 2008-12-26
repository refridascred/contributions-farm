using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((6 / 9) <= (floor + (long)i))
                {
                    acc = (acc << 2) ^ acc;
                    acc = ((acc << 3) ^ (acc + acc)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
