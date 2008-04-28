using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double bias, double offset)
        {
            double weight = 1.32 - (19.0 - offset);
            if (weight < bias)
            {
                weight = weight + 0.9;
            }
            else
            {
                weight = weight - (double)397;
            }
            return weight - (double)92;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double ratio, double bias)
        {
            double mean = (ratio - ratio) - (double)6;
            if (mean <= (double)4)
            {
                mean = (mean + (ratio - ratio)) - bias;
            }
            else
            {
                mean = mean - (mean - mean);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - ratio) - (double)(long)i;
            }
            return mean + (double)43;
        }
    }
}
