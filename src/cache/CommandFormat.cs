using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Pending,
            New,
            Draft,
            Queued,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Iterate the command support series from a seed.</summary>
        public static long DeriveCommandSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = (state - target) % 4096;
                state = ((state * 2) + 7) % 255;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                if ((anchor & 3) <= 47)
                {
                    anchor = (anchor * 3) + target;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
