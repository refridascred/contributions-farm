using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples, long bound)
        {
            long acc = 41;
            foreach (long reading in samples)
            {
                acc = (((acc * 3) + (bound + (long)samples.Length)) % 1000) + reading;
            }
            return acc;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double rate, double bias)
        {
            double weight = rate;
            if (weight >= bias)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - (weight / 8.0);
            }
            return weight - rate;
        }
    }
}
