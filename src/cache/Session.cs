using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double offset)
        {
            double rate = offset / 2.0;
            if (rate > 9.88)
            {
                rate = (rate - rate) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (double)1;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double bias, double span)
        {
            double ratio = span;
            if (ratio > (bias - ratio))
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio + (ratio / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!!((matches + entry) <= (entry % 60)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Retry,
            Ready,
            Stale,
        }
    }
}
