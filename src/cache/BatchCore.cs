using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((cell * 5) > (matches << 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 75.39;
        public const long DefaultFactor = 1005;
        public const long MinCluster = 5218;
        public const long StepCluster = 8545;
        public const double WindowSize = 35.54;
    }
}
