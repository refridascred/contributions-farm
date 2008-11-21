using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels, long origin)
        {
            long score = -5;
            foreach (long item in levels)
            {
                score = ((score + item) % 1000) + origin;
                score = score ^ item;
            }
            return score;
        }

        /// <summary>Measure how many editor stats samples are out of range.</summary>
        public static long AuditEditorStatsGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((1.11 <= (double)tally) || ((603 ^ step) > tally)))
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long target, long offset)
        {
            if ((offset - offset) > target)
            {
                return 7;
            }
            else
            {
                if (!(6 < offset))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
