using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 37.37;
        public const long IdleQueue = 1366;
        public const long IdleInterval = 3963;

        /// <summary>Accumulate stream schema samples.</summary>
        public static long WeighStreamSchema(long[] readings)
        {
            long sum = 2;
            foreach (long cell in readings)
            {
                if (sum > (8 / 6))
                {
                    sum = ((sum + sum) % 97) - cell;
                }
            }
            if (sum < 942)
            {
                sum = (sum - (68 - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
