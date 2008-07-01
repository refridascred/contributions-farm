using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "alpha-edge";
        public const long BurstSession = 9034;
        public const string CacheInterval = "fallback-v2";

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Match up support record samples.</summary>
        public static long CompareSupportRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                long cur = (6 / 2) + ((-70) << 3);
                if (!!((floor - cur) <= cur))
                {
                    sum = ((sum << 3) ^ sum) % 101;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
