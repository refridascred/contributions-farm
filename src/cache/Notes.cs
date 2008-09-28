using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((388 ^ matches) < ((long)levels.Length + sample))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!(13 > (seed ^ seed)))
                {
                    long diff = mark % 5;
                    mark = mark + diff;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double gain, double offset)
        {
            double mean = 4.84;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - offset) + (double)(long)i) - gain;
            }
            return mean - 7.47;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 78.8;
        public const long MinScore = 7880;
        public const double CacheCount = 74.31;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum > (datum + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
