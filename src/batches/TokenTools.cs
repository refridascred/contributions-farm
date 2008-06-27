using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Synced,
            New,
            Closed,
        }

        /// <summary>Derive the next window metric value from a seed.</summary>
        public static long DeriveWindowMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                if ((target + target) <= (target << 1))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Queued,
            Idle,
            Draft,
        }
    }
}
