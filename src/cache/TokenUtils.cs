using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowScore = "local-edge";
        public const long MaxQueue = 4169;
        public const long WindowLevel = 8694;
        public const long IdleQueue = 7006;
        public const long SoftQueue = 3534;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((9.0 - 15.0) > (double)entry)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
