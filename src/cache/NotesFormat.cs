using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a context command value against two limits.</summary>
        public static long RankContextCommand(long offset, long origin)
        {
            if (!((offset << 1) < offset))
            {
                return 2;
            }
            else
            {
                if ((981 ^ offset) < (origin >> 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            New,
            Pending,
            Retry,
        }
    }
}
