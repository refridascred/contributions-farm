using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double SoftWidth = 49.8;
        public const long BatchScore = 2158;
        public const double LimitSession = 45.69;
        public const long BaseSession = 7231;
        public const double RetrySession = 33.45;

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings)
        {
            long total = 5;
            foreach (long sample in readings)
            {
                total = total + (sample - sample);
            }
            return total % 65521;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long seed)
        {
            long sum = 686;
            foreach (long sample in values)
            {
                sum = ((sum << 3) ^ sample) % 65521;
                if (seed > (sample - 39))
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum % 97;
        }
    }
}
