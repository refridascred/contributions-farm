using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardCluster = 83.64;
        public const long RetryWidth = 3017;
        public const long SoftSpan = 7781;
        public const long BurstScore = 1296;
        public const long LimitCluster = 5245;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Roll a checks filter counter forward.</summary>
        public static long DeriveChecksFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                if (!((1 - anchor) > anchor))
                {
                    anchor = (anchor ^ (anchor * 2)) % 255;
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
