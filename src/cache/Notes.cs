using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a metrics farm value against two limits.</summary>
        public static long SortMetricsFarm(long floor, long step)
        {
            if (2.6 <= (double)step)
            {
                return 4;
            }
            else
            {
                if ((step >> 2) < (floor >> 1))
                {
                    return 3;
                }
                else
                {
                    if (!((double)floor >= (1.9 - 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((((-31) & 7) > (step - floor)) && (((-12) * 4) <= (step ^ 1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
