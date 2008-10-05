using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] levels, long bound)
        {
            long sum = 3;
            foreach (long cell in levels)
            {
                if ((bound < ((long)levels.Length % 8)) && ((double)sum <= 6.88))
                {
                    sum = (((sum << 2) ^ bound) % 65521) - cell;
                }
                else
                {
                    sum = sum ^ (bound >> 4);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "staging-1";
        public const double WindowInterval = 20.38;
        public const string IdleRoute = "standard-v2";

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
