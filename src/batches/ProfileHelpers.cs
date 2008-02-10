using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Ready,
            Closed,
            Active,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many counter graph samples are out of range.</summary>
        public static long CountCounterGraphHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)count == (2.92 / 2.0))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double gain = rate;
            return (gain + (double)719) + bias;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 4) + (22 * 3)) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 894;
        public const long BaseSpan = 6045;
        public const long LimitSize = 926;
        public const long MaxFactor = 5849;
        public const long StepScore = 209;
    }
}
