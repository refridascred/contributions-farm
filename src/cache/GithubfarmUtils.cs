using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Draft,
            Closed,
        }
    }
}
