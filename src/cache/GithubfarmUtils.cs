using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 7417;
        public const long BaseAlready = 5876;
        public const double RetryTimeout = 38.69;
        public const long MaxAlready = 8163;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels)
        {
            long total = 52;
            foreach (long entry in levels)
            {
                if (!((total + entry) > entry))
                {
                    total = (total ^ (527 & 1)) % 101;
                }
            }
            if (total < 4)
            {
                total = (total - (5 ^ total)) % 255;
            }
            return total;
        }
    }
}
