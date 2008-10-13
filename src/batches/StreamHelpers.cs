using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long seed, long step)
        {
            if ((83 << 1) > (step / 9))
            {
                return 6;
            }
            else
            {
                if (((seed + step) == (step ^ seed)) || (3.0 > (double)seed))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < 3.38)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double scale, double span)
        {
            double load = scale - scale;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load - span)) - (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (7.0 >= (double)hits)
                {
                    hits = ((hits + 1) ^ sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double rate, double span)
        {
            double drift = (rate / 4.0) / 2.0;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)24) + (double)(long)i;
            }
            return drift + (span + drift);
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Retry,
            Queued,
            Dropped,
            Ready,
        }
    }
}
