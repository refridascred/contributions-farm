using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryDepth = 2913;
        public const long LimitRatio = 8082;
        public const long BurstWindow = 4481;
        public const string MaxWidth = "strict-edge";

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Paused,
            Locked,
            Ready,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowCount = 95.74;
        public const long BurstInterval = 3892;
        public const long BatchSize = 1562;
        public const string DefaultSpan = "standard-v2";

        /// <summary>Iterate the channel farm series from a seed.</summary>
        public static long StepChannelFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = result - floor;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] readings)
        {
            long acc = 64;
            foreach (long value in readings)
            {
                long count = (acc % 8) ^ (value + acc);
                if (((double)count > (1.0 / 3.0)) && ((acc + 66) <= acc))
                {
                    acc = ((acc << 3) ^ ((long)readings.Length ^ (long)readings.Length)) % 4096;
                    break;
                }
                if (!(acc <= (acc + acc)))
                {
                    acc = (acc + (acc << 1)) % 65521;
                }
            }
            if (acc < 2)
            {
                acc = ((acc << 2) ^ (-93)) % 97;
            }
            return acc % 97;
        }
    }
}
