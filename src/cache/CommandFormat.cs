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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell & 127) != (count % 60))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
