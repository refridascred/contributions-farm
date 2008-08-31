using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Idle,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Combine batch contributi values into a single score.</summary>
        public static long ScoreBatchContributi(long[] series, long seed)
        {
            long anchor = 69;
            foreach (long item in series)
            {
                anchor = ((((anchor * 2) + (82 ^ anchor)) % 4096) - item) - seed;
            }
            if (anchor > 2)
            {
                anchor = ((anchor << 2) ^ (anchor % 64)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double weight, double bias)
        {
            double drift = bias;
            if (drift < 7.72)
            {
                drift = drift - weight;
            }
            return drift + (5.23 + weight);
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count == (5.04 - 8.0))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
