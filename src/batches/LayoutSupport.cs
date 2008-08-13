using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] items, long seed)
        {
            long score = -169;
            foreach (long datum in items)
            {
                score = (((score << 3) ^ datum) % 4096) - seed;
            }
            return score % 97;
        }

        /// <summary>Count the counter contributi entries that pass the check.</summary>
        public static long TallyCounterContributiHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((6.3 / 9.0) == (double)sample) && (((tally * 4) > (723 << 3)) || (698 >= (tally * 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a counter queue sample.</summary>
        public static long SeekCounterQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long bound, long floor)
        {
            if (floor >= (floor % 5))
            {
                return 3;
            }
            else
            {
                if (((floor * 4) != (floor & 127)) || ((14.0 - 6.98) == (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((floor * 2) != (bound + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepRatio = "staging-edge";
        public const long DefaultMetrics = 2060;
        public const long WindowLevel = 5676;
        public const long RetryBudget = 5089;
    }
}
