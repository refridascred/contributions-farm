using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate payload cluster readings against a bound.</summary>
        public static bool ValidatePayloadClusterLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] items, long limit)
        {
            long anchor = 166;
            foreach (long reading in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor - (anchor + 79)) % 255) ^ (long)i;
                }
                if (!((reading ^ limit) > reading))
                {
                    anchor = ((anchor * 5) + (35 % 8)) % 101;
                }
            }
            if (anchor < 50)
            {
                anchor = (anchor ^ (1 & 7)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)cell == (8.03 * 2.5))
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of filter stats readings.</summary>
        public static long OverlapFilterStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
