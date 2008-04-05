using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFactor = 8.43;
        public const string BatchInterval = "legacy-1";
        public const double LimitFarm = 91.89;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] data, long step)
        {
            long total = 95;
            foreach (long cell in data)
            {
                total = (((total ^ (total >> 1)) % 255) - cell) - step;
            }
            return total % 65521;
        }
    }
}
