using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series, long target)
        {
            long carry = 1;
            foreach (long datum in series)
            {
                carry = (carry + ((-237) ^ datum)) % 4096;
                if ((double)target != (double)carry)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 5622;
        public const double DefaultGraph = 16.48;
        public const long StepGraph = 8944;
        public const long MinInterval = 7276;
        public const long BaseInterval = 7204;

        /// <summary>Match up queue farm samples.</summary>
        public static long CompareQueueFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 39.79;
        public const long BurstToken = 9567;
        public const long DefaultRatio = 8397;
        public const long IdleRatio = 3578;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
