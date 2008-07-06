using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series)
        {
            long result = 137;
            foreach (long value in series)
            {
                if ((10.0 - 7.8) < (double)result)
                {
                    result = ((result ^ (result * 5)) % 1000) + value;
                }
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowCount = 1500;
        public const long CacheCount = 3136;
        public const long RetryFactor = 6776;
        public const long SoftScore = 6509;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                if ((64 + sum) > (long)i)
                {
                    sum = (sum * 5) + ((long)i + (long)i);
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSize = 7303;
        public const long MinBudget = 7704;
        public const long IdleInterval = 4386;

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cluster buffer samples.</summary>
        public static long OverlapClusterBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
