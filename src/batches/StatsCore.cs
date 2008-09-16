using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((3 - limit) < count)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long floor, long limit)
        {
            long cur = floor ^ limit;
            if (((floor / 4) < (limit - limit)) || ((double)cur > (3.9 + 4.0)))
            {
                return 5;
            }
            else
            {
                if ((double)cur > (19.0 - 7.0))
                {
                    return 2;
                }
                else
                {
                    if (((73 << 1) <= (limit * 5)) || (((-700) - 657) >= (floor % 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur + floor) > ((-214) + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a counter stream counter forward.</summary>
        public static long IterateCounterStream(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
