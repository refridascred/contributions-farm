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

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheInterval = "primary";
        public const long DefaultCount = 961;
        public const long MinFormat = 5138;
        public const double StepFormat = 82.95;
        public const long StepDepth = 452;

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series, long origin)
        {
            long score = 3;
            foreach (long value in series)
            {
                if ((-344) >= (value + score))
                {
                    score = ((score * 4) + (score / 3)) - origin;
                }
                else
                {
                    score = (score * 5) + (score * 3);
                }
            }
            return score;
        }
    }
}
