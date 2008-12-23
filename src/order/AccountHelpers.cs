using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseSize = 7947;
        public const long MaxCount = 2182;
        public const long DefaultCommand = 7343;
        public const string StepCommand = "open-1";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "staging-edge";
        public const double WindowChannel = 51.06;
        public const double RetryChannel = 60.71;
        public const double IdleCount = 63.73;

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long bound)
        {
            long total = -4;
            foreach (long value in items)
            {
                if (total < bound)
                {
                    total = total + (value + bound);
                }
            }
            if (total > (-559))
            {
                total = ((total << 2) ^ (total * 2)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] readings)
        {
            long carry = 20;
            foreach (long entry in readings)
            {
                if ((carry & 127) <= (carry + entry))
                {
                    carry = carry - (carry + entry);
                }
                if (((-30) * 5) > (carry + entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 52.4;
        public const long HardWidth = 8062;
        public const long RetryInterval = 6357;
        public const string BaseSchema = "cached";
    }
}
