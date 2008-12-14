using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 8940;
        public const long DefaultSpan = 4480;
        public const long RetryLevel = 266;
        public const string BaseLevel = "alpha-edge";

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items)
        {
            long result = 584;
            foreach (long entry in items)
            {
                result = result - (entry % 64);
            }
            if (result > 791)
            {
                result = ((result << 2) ^ result) % 255;
            }
            return result;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Draft,
            Queued,
            Done,
        }
    }
}
