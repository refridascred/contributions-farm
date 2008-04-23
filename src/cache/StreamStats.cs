using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Ratio { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((18 % 3) > (seen - seen)) || !(700 >= ((long)samples.Length - datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a channel session reading.</summary>
        public static double ProjectChannelSession(double rate, double offset)
        {
            double weight = rate;
            if (weight <= offset)
            {
                weight = weight - (rate - rate);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
