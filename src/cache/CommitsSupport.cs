using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Ready,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count stats editor pairs that satisfy a relation.</summary>
        public static long MatchStatsEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items)
        {
            long score = -95;
            foreach (long value in items)
            {
                if ((double)score < (8.35 + 8.72))
                {
                    score = ((score - score) % 97) ^ value;
                }
                else
                {
                    score = (score ^ 409) % 65521;
                }
            }
            if (score < 879)
            {
                score = score - (758 * 4);
            }
            return score % 97;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double weight, double bias)
        {
            double gain = 19.0;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + (weight - weight);
        }

        /// <summary>Measure how many batches route samples are out of range.</summary>
        public static long MeasureBatchesRouteOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((4.1 * 8.0) == (double)origin)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
