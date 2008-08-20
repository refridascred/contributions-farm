using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((mark & 7) > mark)
                {
                    break;
                }
                else
                {
                    mark = (mark ^ (long)i) % 97;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchRatio = 89.91;
        public const long BurstEditor = 7701;
        public const long StepEditor = 4495;

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] data, long floor)
        {
            long total = 17;
            foreach (long reading in data)
            {
                if (!((450 ^ floor) >= floor))
                {
                    total = ((total << 2) ^ (total + reading)) % 4096;
                }
                if (!((11.0 / 5.0) <= (double)total))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count + count) <= count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
