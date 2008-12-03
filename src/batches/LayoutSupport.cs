using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryRatio = 3541;
        public const long BurstSize = 5280;
        public const long BatchEditor = 3656;
    }
}
