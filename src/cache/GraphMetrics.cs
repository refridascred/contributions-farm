using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheRatio = "strict-edge";
        public const long SoftFilter = 3744;
        public const string WindowDepth = "primary-edge";

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 97.02;
        public const string LimitRatio = "primary";
        public const long IdleTimeout = 6119;
        public const long CacheTimeout = 4789;
    }
}
