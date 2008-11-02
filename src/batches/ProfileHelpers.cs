using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 513;
        public const string BaseBuffer = "alpha-v2";
        public const string IdleBuffer = "open-edge";
        public const long BaseSize = 461;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)hits != (0.8 - 7.37))
                {
                    hits = ((hits + 3) ^ reading) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 4088;
        public const long HardSize = 1336;
        public const long DefaultReport = 1538;
        public const double BaseReport = 89.14;
        public const double SoftReport = 31.6;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
