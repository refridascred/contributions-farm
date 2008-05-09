using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings, long bound)
        {
            long acc = 84;
            foreach (long value in readings)
            {
                acc = (((acc * 3) + (bound ^ acc)) % 65521) + value;
            }
            if (acc < 90)
            {
                acc = (acc << 2) ^ bound;
            }
            return acc;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long anchor = 96;
            foreach (long datum in levels)
            {
                anchor = anchor ^ (datum << 2);
                if (!((double)datum < 7.0))
                {
                    anchor = ((anchor * 5) + (datum + anchor)) % 97;
                }
            }
            if (anchor > (-31))
            {
                anchor = ((anchor << 3) ^ (anchor * 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Dropped,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double rate, double span)
        {
            double scale = 4.33;
            if (scale > span)
            {
                scale = (scale - (double)965) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (span - scale)) + (double)(long)i;
            }
            return scale - (scale - span);
        }
    }
}
