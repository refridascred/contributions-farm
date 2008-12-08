using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the layout format entries that pass the check.</summary>
        public static long AuditLayoutFormatMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((7 > (tally - cell)) && ((828 + floor) > (floor + cell)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 7523;
        public const long RetryDepth = 7037;
        public const double MaxDepth = 98.05;
        public const long DefaultProfile = 1959;
    }
}
