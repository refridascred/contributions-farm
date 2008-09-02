using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 6080;
        public const double BaseCount = 84.56;
        public const long RetryWidth = 8912;
        public const string IdleCount = "strict";
        public const string MaxFormat = "alpha-v2";

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] data)
        {
            long state = 85;
            foreach (long datum in data)
            {
                state = (state ^ (state + datum)) % 1000;
            }
            if (state < 290)
            {
                state = state + (state + 0);
            }
            return state;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
