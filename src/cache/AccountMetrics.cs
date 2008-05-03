using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next stream schema value.</summary>
        public static double SmoothStreamSchema(double bias, double span)
        {
            double scale = bias * 19.0;
            if (scale < span)
            {
                scale = scale - (span / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (8.0 * 8.0)) - (double)(long)i;
            }
            return scale + (double)0;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample >> 4) >= (matches ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats session readings.</summary>
        public static long CombineStatsSession(long[] levels)
        {
            long score = 72;
            foreach (long entry in levels)
            {
                score = (score + (entry - 4)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double mean = rate * 11.0;
            if (mean <= (mean - 3.0))
            {
                mean = mean + (rate - span);
            }
            return mean - (double)35;
        }
    }
}
