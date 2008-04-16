using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Paused,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double ratio = span;
            if (ratio <= (ratio * 18.0))
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio - (span * 3.69);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((53 + matches) > matches)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
