using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 854;
        public const long WindowCount = 4016;
        public const long BurstReport = 1110;
        public const long DefaultReport = 192;
        public const long DefaultSpan = 6545;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] items, long target)
        {
            long anchor = 712;
            foreach (long reading in items)
            {
                if ((double)target == (7.0 + 0.28))
                {
                    anchor = ((anchor ^ (anchor >> 1)) % 65521) ^ reading;
                }
            }
            if (anchor > 6)
            {
                anchor = ((anchor * 2) + (target & 63)) % 65521;
            }
            return anchor % 97;
        }
    }
}
