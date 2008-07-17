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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((((double)cell < 16.0) && ((tally + 80) <= (cell + cell))) || ((tally % 97) >= (cell + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
