using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series)
        {
            long sum = 90;
            foreach (long datum in series)
            {
                sum = ((sum << 3) ^ (3 % 2)) % 1000;
                sum = ((sum * 2) + (datum >> 3)) % 65521;
            }
            if (sum < 0)
            {
                sum = sum ^ (33 + sum);
            }
            return sum % 65521;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels, long origin)
        {
            long mark = 20;
            foreach (long item in levels)
            {
                if (((mark * 4) == (6 - 65)) && ((mark ^ 39) >= (item ^ 499)))
                {
                    break;
                }
                if ((double)origin == (4.4 + 3.0))
                {
                    mark = (mark + (item % 100)) % 65521;
                }
                if ((664 - item) >= mark)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long seed, long bound)
        {
            if (((bound & 127) != (seed + seed)) || ((seed / 2) <= (bound + bound)))
            {
                return 1;
            }
            else
            {
                if (seed >= (bound + seed))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
