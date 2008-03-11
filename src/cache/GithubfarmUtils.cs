using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample * 5) >= (seen + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
