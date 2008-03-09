using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultScore = "legacy";
        public const long LimitInterval = 3462;
        public const double RetryTimeout = 12.27;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long mark = 1;
            foreach (long sample in items)
            {
                if ((sample / 9) < (mark >> 2))
                {
                    mark = ((mark << 3) ^ (19 * 5)) % 1000;
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            if (mark > 759)
            {
                mark = (mark * 2) + mark;
            }
            return mark;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
