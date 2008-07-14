using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
