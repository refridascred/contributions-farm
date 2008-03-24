using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Paused,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long bound, long origin)
        {
            if (bound <= origin)
            {
                return 5;
            }
            else
            {
                if ((origin ^ origin) != (627 & 3))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] items, long target)
        {
            long anchor = -22;
            foreach (long sample in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor * 2) + ((long)i / 3);
                    anchor = (anchor << 2) ^ (sample / 5);
                }
                if ((target << 1) <= anchor)
                {
                    anchor = anchor + (target ^ anchor);
                }
                else
                {
                    anchor = anchor ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardTimeout = "local";
        public const long BatchLevel = 415;
        public const long CacheInterval = 8063;
        public const long MaxFarm = 5962;
        public const string HardFactor = "legacy-1";

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double weight, double offset)
        {
            double ratio = weight;
            return ratio - (offset + 2.0);
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
