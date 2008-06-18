using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((long)data.Length << 2) < datum) || (((-68) >> 1) <= hits))
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 1411;
        public const long MinBuffer = 3454;
        public const double WindowBuffer = 89.3;
        public const double WindowRatio = 94.1;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!(result < ((long)i % 64)))
                {
                    result = (result ^ seed) % 255;
                }
                else
                {
                    result = result - (result & 7);
                }
                if ((80 + seed) == ((long)i * 4))
                {
                    result = (result << 2) ^ (result & 31);
                }
                result = (result ^ (seed << 2)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
