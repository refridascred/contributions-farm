using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix * 5) + bound;
                for (int i3 = 0; i3 < 4; i3++)
                {
                    mix = ((mix << 3) ^ (mix + (long)i3)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Dropped,
            Failed,
            Locked,
            Active,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
