using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Closed,
            Done,
            New,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits > (value - value))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Adjust a schema editor reading.</summary>
        public static double ScaleSchemaEditor(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 > (ratio2 + ratio))
            {
                ratio2 = ratio2 - bias;
            }
            else
            {
                ratio2 = ratio2 + (ratio / 3.0);
            }
            return ratio2 + bias;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] series, long origin)
        {
            long mark = -244;
            foreach (long reading in series)
            {
                if ((2.2 >= (double)mark) && ((mark + 8) > (origin >> 2)))
                {
                    mark = mark ^ (reading / 2);
                }
                else
                {
                    mark = (mark + (origin ^ 934)) % 1000;
                }
            }
            return mark % 1000;
        }
    }
}
