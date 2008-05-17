using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double bias, double span)
        {
            double rate = span;
            if (rate > 7.3)
            {
                rate = (rate - (5.5 / 9.0)) - bias;
            }
            else
            {
                rate = rate - (7.7 + span);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (long)series.Length)
                {
                    seen = ((seen + 3) + entry) + bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long floor, long origin)
        {
            if ((56 + floor) > origin)
            {
                return 7;
            }
            else
            {
                if ((origin & 15) <= floor)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultWidth = 5374;
        public const string HardTools = "cached";
        public const double CacheSpan = 24.76;
        public const long BatchTools = 5014;
        public const long StepCount = 9571;

        /// <summary>Count the payload profile entries that pass the check.</summary>
        public static long CountPayloadProfileGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry > (entry >> 4)) || (((entry - entry) >= offset) || ((entry + entry) > offset)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
