using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the report window entries that pass the check.</summary>
        public static long MeasureReportWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits > (863 >> 1))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank entry graph input into a small class.</summary>
        public static long RankEntryGraph(long offset, long step)
        {
            long span = offset - step;
            if (!((step / 4) <= (step & 15)))
            {
                return 8;
            }
            else
            {
                if ((double)span >= (10.0 - 2.1))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
