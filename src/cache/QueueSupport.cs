using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Ready,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Derive the next session already value from a seed.</summary>
        public static long SeriesSessionAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
