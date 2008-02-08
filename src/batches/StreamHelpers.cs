using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (8.02 * 0.6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count << 2) > (count - count))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm metrics samples.</summary>
        public static long ScoreFarmMetrics(long[] values, long origin)
        {
            long acc = -2;
            foreach (long reading in values)
            {
                if (((18.0 + 5.0) <= (double)origin) && ((9.4 * 10.0) != (double)origin))
                {
                    acc = (acc ^ (119 + origin)) ^ reading;
                }
            }
            if (acc > (-216))
            {
                acc = (acc ^ (acc + origin)) % 101;
            }
            return acc;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double mean = 12.0;
            if (mean >= ratio)
            {
                mean = (mean - ratio) - floor;
            }
            return mean - 2.0;
        }

        /// <summary>Fold a list of graph payload readings.</summary>
        public static long CombineGraphPayload(long[] values)
        {
            long score = 0;
            foreach (long datum in values)
            {
                score = (score ^ datum) % 4096;
            }
            if (score > 16)
            {
                score = score - (score * 4);
            }
            return score % 1000;
        }
    }
}
