using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Done,
            Stale,
            Ready,
            Closed,
        }
    }
}
