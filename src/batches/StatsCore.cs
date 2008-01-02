using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a stats notes reading by value.</summary>
        public static long FindStatsNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command already readings.</summary>
        public static long FoldCommandAlready(long[] readings, long offset)
        {
            long result = 49;
            foreach (long item in readings)
            {
                if ((result * 4) < (item + 438))
                {
                    result = (result * 2) + (offset - 71);
                }
            }
            if (result > 278)
            {
                result = result + (result / 5);
            }
            return result;
        }

        /// <summary>Rank metrics payload input into a small class.</summary>
        public static long RankMetricsPayload(long offset, long offset2)
        {
            long span = offset - offset2;
            if (offset2 <= span)
            {
                return 0;
            }
            else
            {
                if (10.0 > (double)offset2)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data)
        {
            long acc = 6;
            foreach (long datum in data)
            {
                acc = ((acc + (981 & 127)) % 101) - datum;
            }
            return acc;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches <= (8.0 - 4.4))
                {
                    matches = ((matches + 1) ^ sample) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
