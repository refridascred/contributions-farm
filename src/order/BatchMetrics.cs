using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data, long step)
        {
            long state = 71;
            foreach (long item in data)
            {
                state = (state - item) % 255;
                if (!(item <= (step * 5)))
                {
                    state = (state << 3) ^ (item + item);
                }
            }
            if (state > 906)
            {
                state = (state + step) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((target & 31) == (hits >> 5))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = (result ^ ((long)i / 6)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
        }
    }
}
