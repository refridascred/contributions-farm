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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                if (((mark >> 5) < mark) || ((double)mark <= 7.1))
                {
                    mark = ((mark * 5) + mark) % 97;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
