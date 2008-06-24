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

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
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

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 98.41;
        public const double WindowAlready = 28.13;
        public const long StepTimeout = 4793;
        public const long HardAlready = 5438;
    }
}
