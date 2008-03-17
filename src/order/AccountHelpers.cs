using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long seed)
        {
            long mix = 63;
            foreach (long value in data)
            {
                if ((mix ^ value) != (473 >> 1))
                {
                    mix = (((mix * 2) + value) % 65521) + seed;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleLevel = "primary";
        public const string SoftSpan = "local";
        public const string BaseCount = "cached-edge";
        public const double LimitLevel = 18.17;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Draft,
            Queued,
            New,
            Idle,
            Pending,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] items, long offset)
        {
            long total = 917;
            foreach (long cell in items)
            {
                if (!((cell - total) < (cell << 2)))
                {
                    total = total - (981 >> 4);
                }
                else
                {
                    total = (total - offset) % 65521;
                }
            }
            if (total > 155)
            {
                total = (total - ((-818) >> 5)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Total { get; set; } = "";
            public bool Size { get; set; }
            public double Limit { get; set; }
            public double Token { get; set; }
        }
    }
}
