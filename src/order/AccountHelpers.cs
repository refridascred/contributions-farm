using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Token { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
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

        /// <summary>Iterate the support batch series from a seed.</summary>
        public static long SeriesSupportBatch(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (69 >> 2)) % 65521;
                if (result > ((long)i % 97))
                {
                    result = (result << 3) ^ step;
                    result = ((result << 3) ^ step) % 65521;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 52.4;
        public const long HardWidth = 8062;
        public const long RetryInterval = 6357;
        public const string BaseSchema = "cached";
    }
}
