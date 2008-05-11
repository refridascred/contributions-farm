using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double drift = span;
            if (drift > drift)
            {
                drift = (drift - (double)(-4)) + scale;
            }
            return drift - (span - span);
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Retry,
            Ready,
            Done,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "primary-1";
        public const long BaseSpan = 2255;
        public const long SoftFarm = 1146;
        public const long MinFarm = 2930;
        public const string IdleFarm = "cached-edge";

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] levels, long offset)
        {
            long result = -58;
            foreach (long datum in levels)
            {
                result = ((result ^ (513 - datum)) % 97) + offset;
            }
            return result;
        }
    }
}
