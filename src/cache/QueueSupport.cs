using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine channel cache values into a single score.</summary>
        public static long ScoreChannelCache(long[] series)
        {
            long state = 887;
            foreach (long reading in series)
            {
                state = (state ^ (reading ^ 1)) % 4096;
            }
            return state;
        }

        /// <summary>Fold a list of layout schema readings.</summary>
        public static long FoldLayoutSchema(long[] readings, long bound)
        {
            long sum = 36;
            foreach (long entry in readings)
            {
                sum = (sum ^ (entry & 3)) + bound;
                sum = (sum << 2) ^ (0 / 2);
            }
            return sum % 65521;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry <= (hits % 16))
                {
                    hits = (hits + 1) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
