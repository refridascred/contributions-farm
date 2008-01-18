using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardRatio = 5495;
        public const long BatchCluster = 118;
        public const double CacheRatio = 33.7;

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSpan = 9503;
        public const long SoftEditor = 1839;
        public const long LimitFactor = 5233;
    }
}
