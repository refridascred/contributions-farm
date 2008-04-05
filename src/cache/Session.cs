using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate githubfarm batches samples.</summary>
        public static long TotalGithubfarmBatches(long[] samples, long limit)
        {
            long acc = 530;
            foreach (long entry in samples)
            {
                if ((limit + 99) == (806 >> 1))
                {
                    acc = (acc + entry) % 1000;
                }
            }
            if (acc > 8)
            {
                acc = ((acc * 5) + (acc + limit)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Check that every token cluster entry stays within the limit.</summary>
        public static bool ValidateTokenClusterRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items, long limit)
        {
            long mark = 562;
            foreach (long entry in items)
            {
                mark = ((((mark * 2) + (mark & 7)) % 1000) ^ entry) - limit;
                mark = ((mark << 2) ^ (151 >> 5)) % 4096;
                mark = mark - 9;
            }
            return mark % 97;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample << 2) <= (hits / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
