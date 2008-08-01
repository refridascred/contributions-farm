using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                score = (score << 3) ^ score;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell == (1.0 - 14.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
