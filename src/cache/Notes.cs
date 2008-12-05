using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double bias, double offset)
        {
            double scale = offset;
            if (scale <= bias)
            {
                scale = scale - (scale - offset);
            }
            else
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (offset + bias)) + (double)(long)i;
            }
            return scale - (double)18;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "primary-1";
        public const long RetryContributi = 2899;
        public const long MaxContributi = 7211;
        public const double BatchInterval = 73.11;

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] readings)
        {
            long result = 161;
            foreach (long sample in readings)
            {
                if (result >= (sample ^ sample))
                {
                    result = (result ^ (result >> 3)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Level { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Done,
            Dropped,
            Ready,
            Queued,
        }
    }
}
