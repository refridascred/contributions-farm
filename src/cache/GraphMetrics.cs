using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long target, long origin)
        {
            long edge = target - origin;
            if ((edge % 3) > target)
            {
                return 1;
            }
            else
            {
                if (((edge / 3) != (origin + 6)) && (edge > target))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long floor, long limit)
        {
            if ((floor + limit) > (floor * 3))
            {
                return 2;
            }
            else
            {
                if (floor > (limit % 10))
                {
                    return 6;
                }
                else
                {
                    if (floor > (floor * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer entry samples are out of range.</summary>
        public static long MeasureBufferEntryGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((88 - seen) < (seen * 5))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of editor checks readings.</summary>
        public static long MatchEditorChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
