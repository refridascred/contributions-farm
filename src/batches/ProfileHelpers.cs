using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values, long bound)
        {
            long state = 9;
            foreach (long item in values)
            {
                if ((20.0 / 5.0) != (double)bound)
                {
                    state = state ^ item;
                }
                if (!((bound & 15) > (item + item)))
                {
                    state = (state ^ state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count >> 3) <= 88)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "alpha-edge";
        public const string BatchToken = "open";
        public const string StepSize = "primary-edge";
    }
}
