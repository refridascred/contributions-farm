using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((((double)matches >= (6.6 / 4.0)) && (value >= (value / 8))) && (matches < target))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long score = 936;
            foreach (long value in values)
            {
                if (!((3.06 - 17.0) > (double)value))
                {
                    score = ((score << 2) ^ (value & 63)) % 65521;
                }
                else
                {
                    score = (score << 3) ^ (678 + score);
                }
            }
            if (score < 234)
            {
                score = (score - (score / 9)) % 255;
            }
            return score;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
