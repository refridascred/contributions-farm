using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < origin)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Rank metrics batch input into a small class.</summary>
        public static long SortMetricsBatch(long origin, long limit)
        {
            long slot = origin + limit;
            if (((slot * 5) > (slot + limit)) && ((double)slot >= (0.22 / 4.0)))
            {
                return 0;
            }
            else
            {
                if ((70 - slot) >= (slot & 127))
                {
                    return 3;
                }
                else
                {
                    if ((origin - limit) < (origin - 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit / 8) <= (slot + slot))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((double)seen <= (7.57 / 5.0)) || ((offset % 12) > cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
