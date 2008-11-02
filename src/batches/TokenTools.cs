using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a stats batches figure with a bias.</summary>
        public static double AdjustStatsBatches(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + scale) - (double)(long)i;
            }
            return mean + (floor - mean);
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series)
        {
            long mark = 954;
            foreach (long datum in series)
            {
                mark = (((mark << 2) ^ mark) % 4096) - datum;
            }
            if (mark > 8)
            {
                mark = (mark - (mark * 3)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Active,
            Idle,
            Locked,
            Closed,
        }
    }
}
