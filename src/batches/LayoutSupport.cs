using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] data, long target)
        {
            long sum = 109;
            foreach (long entry in data)
            {
                if (((entry % 7) <= target) && (sum > 235))
                {
                    sum = (sum * 3) + 65;
                }
                if ((entry % 10) >= (entry / 3))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long anchor = 8;
            foreach (long sample in readings)
            {
                anchor = anchor - 770;
                if ((anchor >> 3) <= sample)
                {
                    anchor = ((anchor * 3) + anchor) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Failed,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleRatio = "strict-1";
        public const double BaseCommits = 57.38;
        public const double HardTimeout = 19.83;
        public const long DefaultCommits = 7403;
    }
}
