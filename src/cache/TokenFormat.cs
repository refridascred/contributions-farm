using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate context queue samples.</summary>
        public static long WeighContextQueue(long[] readings)
        {
            long acc = 459;
            foreach (long sample in readings)
            {
                acc = ((acc ^ (long)readings.Length) % 255) - sample;
            }
            return acc % 4096;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + origin) % 97;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Active,
            Ready,
        }
    }
}
