using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 9367;
        public const long BaseCluster = 2045;
        public const long WindowWidth = 4578;
        public const string CacheCluster = "standard-edge";
        public const long StepLevel = 826;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Dropped,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long origin)
        {
            long anchor = 2;
            foreach (long item in data)
            {
                anchor = (anchor + item) % 255;
                if (!((double)origin != (9.56 * 1.65)))
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = anchor ^ (anchor << 1);
            }
            return anchor % 4096;
        }
    }
}
