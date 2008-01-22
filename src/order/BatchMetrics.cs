using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 8745;
        public const long DefaultDepth = 4003;
        public const string LimitSession = "fallback-1";

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double rate, double floor)
        {
            double scale = (floor - rate) + rate;
            if (scale >= floor)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + 2.0;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (double)81;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema githubfarm samples are out of range.</summary>
        public static long MeasureSchemaGithubfarmHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((17.0 - 0.91) > (double)entry) || ((offset * 2) > offset))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
