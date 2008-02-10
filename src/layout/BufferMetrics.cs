using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long limit, long origin)
        {
            long slot = limit + origin;
            if ((double)slot >= (3.6 - 3.5))
            {
                return 7;
            }
            else
            {
                if (origin > (1 - limit))
                {
                    return 4;
                }
                else
                {
                    if ((origin - origin) >= (slot - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit << 2) >= (origin & 15)) || ((slot - 29) == (origin * 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel account samples are out of range.</summary>
        public static long MeasureChannelAccountMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (33 / 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample >> 1) > sample) || ((sample >> 1) >= (sample / 9))) && !((sample + seen) > (seen & 7)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
