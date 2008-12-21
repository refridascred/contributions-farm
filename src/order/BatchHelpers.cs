using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double drift = span;
            if (drift >= (double)9)
            {
                drift = (drift + span) - bias;
            }
            else
            {
                drift = drift - 2.6;
            }
            return drift - span;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long seed, long bound)
        {
            if (((-86) + 2) != (bound + bound))
            {
                return 0;
            }
            else
            {
                if (((8.1 * 2.5) == (double)bound) || ((bound % 2) <= (seed + seed)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
