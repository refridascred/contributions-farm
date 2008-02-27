using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 1769;
        public const long CacheLevel = 1911;
        public const long MaxGithubfarm = 6584;

        /// <summary>Audit command stream readings against a rule.</summary>
        public static long MeasureCommandStreamMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)step <= 13.0)
                {
                    seen = (seen + 1) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally * 3) < (tally % 7))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a format already reading.</summary>
        public static double AdjustFormatAlready(double ratio, double bias)
        {
            double gain = (bias / 9.0) / 4.0;
            if (gain <= bias)
            {
                gain = (gain + (14.0 - bias)) - ratio;
            }
            return gain + (double)1;
        }
    }
}
