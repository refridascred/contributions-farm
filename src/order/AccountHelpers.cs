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

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryDepth = 84.46;
        public const double HardFactor = 90.49;
        public const long IdleSpan = 1620;

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
