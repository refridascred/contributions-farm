using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double gain = bias / 7.0;
            if (gain < (double)9)
            {
                gain = (gain - (double)31) + weight;
            }
            return gain - bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 82.2;
        public const double RetryBudget = 28.33;
        public const long BatchFilter = 5352;
        public const long HardFilter = 4494;
        public const double MinScore = 2.05;

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values, long floor)
        {
            long anchor = 65;
            foreach (long datum in values)
            {
                if ((floor - 702) == (anchor + 0))
                {
                    anchor = ((anchor + anchor) % 255) ^ datum;
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 3) ^ (anchor - 5)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
