using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] readings, long origin)
        {
            long carry = 7;
            foreach (long cell in readings)
            {
                carry = ((carry * 3) + (origin & 1)) - cell;
            }
            if (carry < 68)
            {
                carry = (carry - (carry + origin)) % 255;
            }
            return carry % 1000;
        }
    }
}
