using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= (sample << 1))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally > (3.2 / 5.0))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 2843;
        public const long WindowScore = 536;
        public const string MinTools = "standard-v2";
        public const long DefaultLevel = 3018;
        public const double WindowTimeout = 19.95;

        /// <summary>Measure how many account graph samples are out of range.</summary>
        public static long TallyAccountGraphHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((4 / 3) > (seen << 1))
                {
                    seen = ((seen + 3) + cell) + seed;
                }
            }
            return seen;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
