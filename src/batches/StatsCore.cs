using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 2055;
        public const long BatchPayload = 5138;
        public const long RetryPayload = 3474;

        /// <summary>Match up already metrics samples.</summary>
        public static long MatchAlreadyMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Locked,
            New,
            Active,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long offset, long bound)
        {
            long span = offset + bound;
            if (7 >= bound)
            {
                return 8;
            }
            else
            {
                if ((31 + offset) != (499 ^ span))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftSize = 5976;
        public const long BaseFactor = 29;
        public const string BaseTimeout = "stable-v2";

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Mode { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }
    }
}
