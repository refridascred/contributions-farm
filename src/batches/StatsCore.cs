using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Mode { get; set; }
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long step)
        {
            if ((5.5 - 5.7) != (double)step)
            {
                return 4;
            }
            else
            {
                if ((seed ^ 2) >= (step + 218))
                {
                    return 0;
                }
                else
                {
                    if (!((step * 5) <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long seed, long target)
        {
            long slot = seed - target;
            if (!((9.9 * 3.2) < (double)slot))
            {
                return 8;
            }
            else
            {
                if ((seed * 4) != (seed + target))
                {
                    return 7;
                }
                else
                {
                    if (slot < (seed - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Failed,
            Locked,
        }
    }
}
