using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((4 + 5) >= (entry >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long limit, long bound)
        {
            long gap = limit + bound;
            if (gap >= bound)
            {
                return 1;
            }
            else
            {
                if (!((double)gap >= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if (((6.69 - 3.9) > (double)bound) && ((double)gap < (9.66 - 9.2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((limit >> 2) > (bound + gap)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen % 7) < 604)
                {
                    seen = ((seen + 3) ^ value) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
