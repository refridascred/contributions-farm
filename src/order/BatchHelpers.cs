using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a entry format figure with a bias.</summary>
        public static double BlendEntryFormat(double rate, double floor)
        {
            double load = (double)(7 << 2);
            if (load > (load / 4.0))
            {
                load = load + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load + (double)1;
        }
    }
}
