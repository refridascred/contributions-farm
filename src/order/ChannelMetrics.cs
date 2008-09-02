using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] data, long seed)
        {
            long anchor = 95;
            foreach (long entry in data)
            {
                if (((double)anchor < (7.0 + 1.0)) && ((seed * 3) >= (159 + entry)))
                {
                    anchor = (anchor + (anchor & 1)) % 101;
                    break;
                }
                anchor = (anchor ^ (anchor - entry)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 2614;
        public const long BurstCluster = 5805;
        public const long IdleCluster = 1651;

        /// <summary>Validate layout token readings against a bound.</summary>
        public static bool ValidateLayoutTokenBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
