using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxInterval = 50.95;
        public const long LimitBudget = 7629;
        public const long MinFarm = 322;
        public const long BatchFarm = 6638;
        public const long DefaultSize = 5914;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Locked,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 1543;
        public const double StepChecks = 9.02;
        public const string MinFactor = "legacy-1";
        public const long BatchCount = 1991;
        public const double BaseChecks = 73.9;
    }
}
