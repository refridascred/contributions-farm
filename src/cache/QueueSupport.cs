using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 3204;
        public const long LimitInterval = 6750;
        public const long BurstAlready = 3099;
        public const double MinAlready = 92.15;
        public const string BaseAlready = "cached-edge";

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
