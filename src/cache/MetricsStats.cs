using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (3.0 >= (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Locked,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double bias, double bias2)
        {
            double drift = bias2;
            if (drift > bias2)
            {
                drift = (drift + (double)2) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (7.02 - 1.07)) + (double)(long)i;
            }
            return drift + (bias2 / 2.0);
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double ratio, double floor)
        {
            double mean = (ratio * 5.9) * 8.2;
            if (mean < 9.0)
            {
                mean = (mean - ratio) + floor;
            }
            else
            {
                mean = mean + (double)54;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 11.0) + (double)(long)i;
            }
            return mean + (double)(-185);
        }
    }
}
