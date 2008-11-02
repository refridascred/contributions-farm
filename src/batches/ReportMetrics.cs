using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (weight * 1.12)) - (double)(long)i) + ratio;
            }
            return weight - (9.97 * 4.07);
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
