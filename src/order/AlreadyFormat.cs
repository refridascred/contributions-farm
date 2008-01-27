using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a context metric figure with a bias.</summary>
        public static double BlendContextMetric(double rate, double floor)
        {
            double ratio = floor;
            if (ratio > (double)0)
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio - (double)61;
            }
            return ratio - rate;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items, long step)
        {
            long state = 623;
            foreach (long cell in items)
            {
                if ((step & 127) != (step >> 4))
                {
                    state = state - (state / 7);
                }
                else
                {
                    state = (state - (cell + cell)) % 255;
                }
                if ((state / 2) < state)
                {
                    state = ((state * 2) + state) % 97;
                }
            }
            return state;
        }

        /// <summary>Combine notes filter values into a single score.</summary>
        public static long CombineNotesFilter(long[] samples)
        {
            long total = 42;
            foreach (long item in samples)
            {
                if (80 < (item % 64))
                {
                    total = total - (33 % 7);
                }
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
