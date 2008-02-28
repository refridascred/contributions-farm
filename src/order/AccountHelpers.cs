using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] readings)
        {
            long sum = 441;
            foreach (long cell in readings)
            {
                if ((sum + sum) == (sum + cell))
                {
                    sum = (sum * 5) + cell;
                }
            }
            return sum;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double rate, double offset)
        {
            double ratio = (offset - offset) * 2.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (9.07 - rate)) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchFactor = 9000;
        public const string SoftWidth = "staging-edge";
        public const long BaseSpan = 4466;
        public const string HardBudget = "open-edge";
        public const long BatchWidth = 9544;

        /// <summary>Find the first commits session entry that matches the target.</summary>
        public static long LookupCommitsSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Idle,
            New,
        }
    }
}
