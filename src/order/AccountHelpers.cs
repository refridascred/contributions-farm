using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double mean = (double)(3 - 89);
            if (mean <= (13.0 + 3.0))
            {
                mean = mean - (bias / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (5.42 + floor)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result << 3) ^ (result / 2)) ^ (long)i2;
                    result = result - (result >> 2);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 8896;
        public const long IdleQueue = 3677;
        public const long HardQueue = 2253;
        public const long BaseSize = 4609;
        public const string BatchQueue = "fallback-edge";

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }
    }
}
