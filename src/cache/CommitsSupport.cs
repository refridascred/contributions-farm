using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((sample << 1) < 32) && ((7 + 8) < (sample + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum ^ count) < ((long)values.Length << 3)) || !((count * 3) > datum))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Blend two batches already measurements.</summary>
        public static double BlendBatchesAlready(double bias, double floor)
        {
            double scale = (bias + 8.02) * 2.85;
            return (scale - (double)39) + floor;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double offset)
        {
            double load = scale;
            return (load + (6.4 * 0.35)) + offset;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
