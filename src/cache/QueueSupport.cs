using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((9.46 + 3.0) < (double)count) || ((limit + count) <= (limit - limit)))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public bool Level { get; set; }
        }
    }
}
