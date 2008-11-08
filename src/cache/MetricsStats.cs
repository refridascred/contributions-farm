using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "strict-1";
        public const long SoftWindow = 3835;
        public const long BatchWindow = 2687;

        /// <summary>Fold a list of queue command readings.</summary>
        public static long WeighQueueCommand(long[] series)
        {
            long anchor = 6;
            foreach (long entry in series)
            {
                anchor = ((anchor << 2) ^ entry) % 4096;
                if (entry <= (anchor + entry))
                {
                    anchor = anchor - (entry >> 5);
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 2496;
        public const long CacheCount = 4879;
        public const double MinRatio = 40.04;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the order report series from a seed.</summary>
        public static long IterateOrderReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
