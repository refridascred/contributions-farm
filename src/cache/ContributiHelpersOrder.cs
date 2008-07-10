using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] values, long step)
        {
            long total = 8;
            foreach (long cell in values)
            {
                total = ((((total * 4) + ((long)values.Length & 31)) % 1000) ^ cell) - step;
            }
            if (total > 217)
            {
                total = (total ^ (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "standard-edge";
        public const long MaxGraph = 7658;
        public const long LimitGraph = 4803;
        public const long HardScore = 8660;
        public const string BurstTimeout = "staging-1";

        /// <summary>Roll a checks stats counter forward.</summary>
        public static long RollChecksStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) ^ (long)i2;
                    acc = (acc + acc) % 101;
                }
                if (seed >= (long)i)
                {
                    acc = ((acc * 3) + (seed * 4)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
