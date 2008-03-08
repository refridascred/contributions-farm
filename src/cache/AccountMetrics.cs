using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items)
        {
            long mark = 4;
            foreach (long datum in items)
            {
                mark = (mark ^ (mark * 5)) % 255;
                if ((6.98 + 19.0) > (double)datum)
                {
                    mark = (mark - (mark - datum)) % 1000;
                }
            }
            return mark;
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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
