using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 7214;
        public const double HardReport = 43.69;
        public const long CacheDepth = 3789;
        public const long HardSpan = 1477;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] items)
        {
            long total = 7;
            foreach (long item in items)
            {
                if (total < (total ^ item))
                {
                    total = (total - (item + item)) % 1000;
                }
            }
            if (total > 627)
            {
                total = (total ^ (total / 3)) % 97;
            }
            return total % 97;
        }
    }
}
