using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double scale, double bias)
        {
            double rate = bias;
            if (rate > (scale / 7.0))
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate - (double)3;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (bias / 9.0)) + (double)(long)i;
            }
            return rate + (double)386;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a layout commits figure with a bias.</summary>
        public static double SmoothLayoutCommits(double bias, double floor)
        {
            double drift = 5.22;
            if (drift >= floor)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (floor - drift)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Active,
            Retry,
            Draft,
        }
    }
}
