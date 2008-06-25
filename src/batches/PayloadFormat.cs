using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "latest-1";
        public const double BurstInterval = 92.63;
        public const long DefaultLevel = 4510;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double ratio = offset * 3.0;
            if (ratio <= (3.0 / 4.0))
            {
                ratio = ratio - (ratio + ratio);
            }
            else
            {
                ratio = ratio - rate;
            }
            return ratio + (1.0 / 4.0);
        }
    }
}
