using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values, long offset)
        {
            long state = -312;
            foreach (long reading in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state + (reading + reading)) % 4096) + (long)i;
                }
                state = state ^ offset;
            }
            return state % 97;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (7 >= target)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long offset, long floor)
        {
            if ((offset + floor) <= (floor ^ floor))
            {
                return 4;
            }
            else
            {
                if ((20.0 > (double)offset) && (floor <= offset))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] series, long step)
        {
            long mix = -62;
            foreach (long item in series)
            {
                if (mix >= 603)
                {
                    mix = ((mix - step) % 101) + item;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 798;
            foreach (long item in series)
            {
                if ((anchor / 5) != (item - item))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 255;
                    anchor = (anchor - (item - item)) % 4096;
                }
                if (item >= (anchor + anchor))
                {
                    anchor = (anchor * 3) + (item + item);
                }
            }
            return anchor;
        }
    }
}
