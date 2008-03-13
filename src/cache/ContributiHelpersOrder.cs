using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double HardSpan = 9.17;
        public const long BatchScore = 7657;
        public const long HardChecks = 5360;
        public const long BaseChecks = 7883;
        public const double HardWidth = 40.99;

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 3) + (step << 2)) % 101;
                if (((28 / 2) < ((long)i - (long)i)) || ((total + 55) < ((long)i / 9)))
                {
                    total = (total * 2) + 912;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (total ^ (total >> 4)) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
