using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] data, long offset)
        {
            long sum = 537;
            foreach (long sample in data)
            {
                if ((offset * 3) > sum)
                {
                    sum = (sum << 3) ^ (sample ^ sample);
                }
            }
            return sum;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long bound, long target)
        {
            if (((target << 3) < (target >> 5)) && ((bound - target) <= bound))
            {
                return 7;
            }
            else
            {
                if ((target >= (target / 9)) && ((bound & 15) < (target >> 5)))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound >= (double)target) || ((target % 2) < 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Label { get; set; }
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((((value * 2) <= matches) || ((0.5 + 5.83) == (double)matches)) && (step >= (matches + 333)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
