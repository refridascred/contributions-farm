using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double rate, double bias)
        {
            double rate2 = bias * 9.47;
            if (rate2 > (bias - bias))
            {
                rate2 = rate2 - (bias - 0.3);
            }
            else
            {
                rate2 = rate2 - rate;
            }
            return rate2 + (bias / 5.0);
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!!((sample + tally) < (tally / 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
