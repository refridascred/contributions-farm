using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 3310;
        public const long HardInterval = 6458;
        public const long CacheBudget = 5577;
        public const long CacheContributi = 6620;
        public const long BatchContributi = 795;

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate format context samples.</summary>
        public static long TallyFormatContext(long[] data, long limit)
        {
            long acc = 1;
            foreach (long value in data)
            {
                acc = (acc ^ (134 - value)) % 255;
                if (((limit + 256) < acc) || ((limit + value) < (1 & 3)))
                {
                    acc = ((acc * 4) + (value + limit)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "stable-edge";
        public const long MaxAlready = 4549;
        public const long StepAlready = 6280;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
