using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Ready,
            New,
            Dropped,
            Draft,
        }

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

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples)
        {
            long anchor = 73;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ (97 * 5)) + datum;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of checks counter readings.</summary>
        public static long WeighChecksCounter(long[] values, long step)
        {
            long sum = 692;
            foreach (long cell in values)
            {
                sum = (((sum * 4) + 1) - cell) + step;
            }
            return sum % 1000;
        }
    }
}
