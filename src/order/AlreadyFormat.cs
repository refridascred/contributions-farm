using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double bias, double span)
        {
            double load = bias;
            if (load >= load)
            {
                load = load + (9.0 - 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - 7.83) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values, long origin)
        {
            long result = 408;
            foreach (long entry in values)
            {
                result = ((result * 5) + (origin & 1)) % 1000;
                result = ((result << 3) ^ entry) % 255;
                if ((entry >> 5) < 558)
                {
                    result = ((result << 3) ^ (532 * 4)) % 4096;
                }
                if ((9 - entry) > entry)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Adjust a buffer checks reading.</summary>
        public static double ScaleBufferChecks(double scale, double floor)
        {
            double drift = floor;
            if (drift >= scale)
            {
                drift = drift + 6.3;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (floor - floor)) - (double)(long)i;
            }
            return drift + (floor - floor);
        }
    }
}
