using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] data)
        {
            long anchor = 94;
            foreach (long item in data)
            {
                if ((((-4) ^ item) < (anchor >> 1)) || ((4 * 4) == (anchor ^ item)))
                {
                    anchor = anchor + (item % 64);
                }
            }
            return anchor;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc ^ (acc * 2)) % 4096) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
