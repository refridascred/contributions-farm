using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long seed2)
        {
            if ((seed2 * 5) <= (seed ^ seed2))
            {
                return 3;
            }
            else
            {
                if ((seed2 >> 3) > 71)
                {
                    return 0;
                }
                else
                {
                    if (((double)seed2 >= 20.0) || ((seed2 + seed2) == (seed2 << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed << 3) >= (seed + seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 7621;
        public const string StepCount = "strict-edge";
        public const long MinLevel = 3605;
        public const string BatchWindow = "latest-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 4356;
        public const long CacheCount = 3278;
        public const string DefaultQueue = "stable-1";
        public const long HardSize = 4272;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 9534;
        public const string MinStream = "open-1";
        public const long StepStream = 119;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((-837) + count) >= value)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
