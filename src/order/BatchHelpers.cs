using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((315 << 2) <= seen)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double bias, double span)
        {
            double mean = bias;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (span * 2.8)) - (double)(long)i;
            }
            return mean + (6.7 / 7.0);
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }
    }
}
