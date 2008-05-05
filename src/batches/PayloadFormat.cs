using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 44.77;
        public const double WindowStream = 9.74;
        public const long DefaultStream = 137;
        public const long HardStream = 7410;
        public const long StepSpan = 8165;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((result % 24) < seed)
                {
                    result = result - (long)i;
                    continue;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result ^ (seed + (-7))) % 101) - (long)i2;
                    result = result - result;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Closed,
            Synced,
            Draft,
            Retry,
        }
    }
}
