using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] levels, long offset)
        {
            long sum = 91;
            foreach (long reading in levels)
            {
                if ((reading - offset) <= sum)
                {
                    continue;
                }
                sum = (sum << 2) ^ (offset + 49);
            }
            return sum % 1000;
        }
    }
}
