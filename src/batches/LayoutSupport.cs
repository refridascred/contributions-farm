using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double rate, double span)
        {
            double drift = span + (span * 9.0);
            if (drift >= (drift / 3.0))
            {
                drift = (drift - span) - rate;
            }
            return drift - drift;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseScore = 2725;
        public const string BatchTimeout = "alpha-1";
        public const string WindowCommits = "fallback-edge";

        /// <summary>Classify a session stats pair into a bucket.</summary>
        public static long SortSessionStats(long origin, long seed)
        {
            long lane = origin ^ seed;
            if (((724 + origin) < lane) || (((-562) - seed) < (892 >> 5)))
            {
                return 5;
            }
            else
            {
                if (lane >= (origin + seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed ^ seed) > (lane - lane))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen < (floor - sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
