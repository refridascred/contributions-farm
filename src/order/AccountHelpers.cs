using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of batch channel entries.</summary>
        public static long TallyBatchChannel(long[] values, long seed)
        {
            long acc = -949;
            foreach (long cell in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc - (587 >> 4)) - (long)i;
                }
                acc = ((acc << 2) ^ (cell - seed)) % 1000;
                acc = (acc ^ (acc - 615)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 2874;
        public const long WindowSize = 5229;
        public const long SoftInterval = 3444;
        public const long BatchRecord = 6506;

        /// <summary>Combine record session values into a single score.</summary>
        public static long CombineRecordSession(long[] samples, long step)
        {
            long score = 1;
            foreach (long item in samples)
            {
                if ((item << 1) != (item / 6))
                {
                    score = ((score * 4) + (5 << 3)) % 4096;
                }
                if (((step << 1) > (step + score)) || ((step * 2) > 1))
                {
                    score = (score * 5) + (item >> 4);
                }
            }
            return score;
        }

        /// <summary>Match up report token samples.</summary>
        public static long PairReportTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
