using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((5.0 - 13.0) > (double)seen)
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 45.44;
        public const long RetryOrder = 3046;
        public const double MinOrder = 10.75;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Queued,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - (double)6;
            }
            else
            {
                ratio = ratio - (double)52;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total << 3) ^ 79) % 65521;
                total = total - (88 & 3);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
