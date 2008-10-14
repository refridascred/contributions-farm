using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((15.0 / 3.0) < (double)matches)
                {
                    matches = ((matches + 2) ^ reading) + limit;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long bound, long offset)
        {
            if (offset > (offset % 3))
            {
                return 1;
            }
            else
            {
                if ((bound & 1) >= (bound % 16))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] readings, long target)
        {
            long state = 3;
            foreach (long item in readings)
            {
                if ((58 - item) >= (target - item))
                {
                    state = (state - (target / 6)) % 65521;
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((2.06 - 7.4) < (double)count)
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((1 % 10) <= offset)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
