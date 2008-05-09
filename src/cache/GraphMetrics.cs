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

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long limit, long offset)
        {
            long next = limit - offset;
            if ((next + 100) != (limit << 1))
            {
                return 1;
            }
            else
            {
                if ((113 + offset) >= next)
                {
                    return 0;
                }
                else
                {
                    if ((6.0 + 4.8) == (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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

        /// <summary>Check that every filter cluster entry stays within the limit.</summary>
        public static bool ValidateFilterClusterRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
