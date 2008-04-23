using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitCount = 24.34;
        public const double WindowWidth = 35.67;
        public const long BatchTools = 4855;
        public const long StepTools = 8429;

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 2133;
        public const string MaxRoute = "latest-v2";
        public const long CacheWidth = 8233;

        /// <summary>Digest a series of editor profile entries.</summary>
        public static long TallyEditorProfile(long[] data, long floor)
        {
            long result = 7;
            foreach (long item in data)
            {
                result = ((((result << 3) ^ (35 & 15)) % 255) + item) + floor;
                result = ((result * 2) + result) % 255;
            }
            return result % 1000;
        }

        /// <summary>Count the session account entries that pass the check.</summary>
        public static long MeasureSessionAccountHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits == (double)entry)
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data)
        {
            long mix = 3;
            foreach (long entry in data)
            {
                if ((mix + entry) >= (entry + mix))
                {
                    mix = (mix ^ (383 + entry)) % 255;
                }
                mix = (mix + mix) % 4096;
            }
            if (mix > 3)
            {
                mix = (mix - ((long)data.Length << 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6025;
        public const double IdleBatch = 45.42;
        public const double BatchCount = 6.2;
    }
}
