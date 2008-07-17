using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxRatio = 15.41;
        public const double CacheGraph = 51.6;
        public const long MaxGraph = 2669;
        public const long IdleGraph = 4147;

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 5423;
        public const double SoftSchema = 65.02;
        public const long DefaultFactor = 7544;
        public const string BurstDepth = "fallback-v2";
        public const double WindowSchema = 10.5;

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((anchor % 10) <= (bound % 100))
                {
                    anchor = anchor - ((long)i ^ 622);
                    anchor = (anchor << 3) ^ (73 - bound);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series, long origin)
        {
            long anchor = 3;
            foreach (long datum in series)
            {
                if ((double)origin != (9.7 * 9.2))
                {
                    anchor = ((anchor ^ (anchor - 515)) % 255) ^ datum;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepBudget = "cached-v2";
        public const string MaxEntry = "cached";
        public const double SoftEntry = 14.51;
        public const double IdleCount = 86.32;
        public const long BatchEntry = 9199;
    }
}
