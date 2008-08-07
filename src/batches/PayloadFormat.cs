using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate tools command samples.</summary>
        public static long TallyToolsCommand(long[] series, long bound)
        {
            long acc = 27;
            foreach (long value in series)
            {
                acc = acc ^ (bound * 2);
                if (7.0 < (double)bound)
                {
                    acc = (acc + (acc - value)) % 101;
                }
                else
                {
                    acc = acc - bound;
                }
            }
            if (acc > 887)
            {
                acc = ((acc * 2) + bound) % 101;
            }
            return acc;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double ratio = (weight / 6.0) * 0.7;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (ratio * 4.0);
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Level { get; set; }
            public double Total { get; set; }
        }
    }
}
