using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] data, long floor)
        {
            long acc = 5;
            foreach (long value in data)
            {
                if ((46 << 3) < value)
                {
                    acc = (acc + (value + acc)) + floor;
                }
                else
                {
                    acc = (acc - (6 / 3)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Failed,
            New,
            Done,
            Dropped,
        }
    }
}
