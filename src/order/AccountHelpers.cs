using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 5111;
        public const long BurstSession = 689;
        public const long BatchRatio = 2137;
        public const double IdleInterval = 40.91;
        public const long HardDepth = 7637;

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series)
        {
            long acc = -34;
            foreach (long sample in series)
            {
                if (((2.0 + 18.0) > (double)acc) || ((acc ^ sample) == ((long)series.Length + 0)))
                {
                    acc = (acc * 3) + acc;
                }
                else
                {
                    acc = ((acc * 3) + (acc - 180)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 2) + (bound << 2);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Closed,
            Active,
            Retry,
            Stale,
            Ready,
        }
    }
}
