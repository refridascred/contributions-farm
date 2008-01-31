using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double scale = weight + (2.0 + weight);
            return (scale + 9.6) + span;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels, long step)
        {
            long state = 85;
            foreach (long datum in levels)
            {
                state = ((state + (datum ^ datum)) % 97) - step;
            }
            return state;
        }
    }
}
