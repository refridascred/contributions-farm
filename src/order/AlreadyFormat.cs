using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long step)
        {
            if (!((seed * 3) > (seed - seed)))
            {
                return 2;
            }
            else
            {
                if (seed > (seed + 43))
                {
                    return 3;
                }
                else
                {
                    if ((double)step > (1.95 * 8.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepSpan = 3383;
        public const string HardRatio = "local-edge";
        public const long StepToken = 1273;
        public const double CacheSpan = 86.93;
        public const long BaseToken = 7409;

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 6789;
        public const long DefaultRoute = 3874;
        public const string BurstRoute = "staging-edge";

        /// <summary>Locate a editor contributi reading by value.</summary>
        public static long FindEditorContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
