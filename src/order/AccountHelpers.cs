using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
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

        /// <summary>Check that every format stats entry stays within the limit.</summary>
        public static bool ValidateFormatStatsBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels)
        {
            long state = 983;
            foreach (long cell in levels)
            {
                if (!((0 >> 1) >= (cell % 2)))
                {
                    state = (state ^ (state + cell)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long floor, long target)
        {
            long next = floor + target;
            if ((double)floor < 7.6)
            {
                return 4;
            }
            else
            {
                if ((double)floor > (8.5 / 3.0))
                {
                    return 3;
                }
                else
                {
                    if (((target + floor) >= (floor << 2)) || ((next ^ floor) == (next - floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next channel metric value.</summary>
        public static double BlendChannelMetric(double weight, double offset)
        {
            double ratio = (double)(2 + 83);
            if (ratio <= (double)76)
            {
                ratio = (ratio - (double)227) + weight;
            }
            else
            {
                ratio = ratio - 2.7;
            }
            return ratio - (offset * 9.0);
        }
    }
}
