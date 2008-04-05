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

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] items)
        {
            long mark = 220;
            foreach (long value in items)
            {
                mark = (((mark * 4) + (mark % 100)) % 255) + value;
            }
            return mark;
        }
    }
}
