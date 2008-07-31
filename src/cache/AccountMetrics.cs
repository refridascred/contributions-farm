using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Label { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a token contributi sample.</summary>
        public static long LookupTokenContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count + count) < (sample % 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((item * 5) > (49 / 3)))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine counter batch values into a single score.</summary>
        public static long DigestCounterBatch(long[] series)
        {
            long mix = 80;
            foreach (long datum in series)
            {
                if (((datum / 9) >= datum) || (datum <= (997 & 7)))
                {
                    mix = (mix - (mix + datum)) % 97;
                }
            }
            return mix;
        }
    }
}
