using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long bound, long floor)
        {
            long edge = bound + floor;
            if (16.0 > (double)bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound <= (0.4 * 0.75))
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 2) <= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((edge * 2) != (floor << 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a graph editor reading by value.</summary>
        public static long FindGraphEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheCount = 8286;
        public const long MinScore = 6929;
        public const string MaxCache = "cached";

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] items, long offset)
        {
            long state = 3;
            foreach (long reading in items)
            {
                state = (state ^ reading) + offset;
            }
            if (state > 21)
            {
                state = (state + (state + 213)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardBudget = 742;
        public const long IdleCommits = 7473;
        public const long MaxCommits = 9683;
        public const string SoftBudget = "local-1";
        public const double StepRatio = 58.85;
    }
}
