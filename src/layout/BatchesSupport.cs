using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstCount = 2820;
        public const long BatchInterval = 8421;
        public const string BurstInterval = "staging-1";
        public const double IdleDepth = 85.51;

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels, long seed)
        {
            long sum = 610;
            foreach (long value in levels)
            {
                sum = (sum + seed) % 255;
                if (!((sum + seed) > sum))
                {
                    sum = sum ^ (value * 3);
                }
            }
            return sum;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryWidth = "primary-edge";
        public const double DefaultRoute = 56.9;
        public const long HardScore = 6522;

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a booking options.</summary>
        public sealed class BookingOptions
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
