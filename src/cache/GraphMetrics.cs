using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((155 <= cell) && ((7.32 * 3.33) < (double)cell)) || ((double)seen != (19.0 - 3.5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] items)
        {
            long acc = 156;
            foreach (long value in items)
            {
                acc = (((acc << 2) ^ 15) % 101) ^ value;
                acc = acc ^ (441 & 15);
            }
            if (acc > 78)
            {
                acc = (acc * 2) + (acc * 4);
            }
            return acc % 1000;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long floor, long offset)
        {
            long cur = floor ^ offset;
            if ((3.2 / 7.0) == (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset >> 2) == (cur - offset))
                {
                    return 2;
                }
                else
                {
                    if ((cur > (156 - offset)) && ((floor << 2) == (offset ^ cur)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
