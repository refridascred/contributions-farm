using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally & 255) <= (reading * 4))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 1370;
        public const string BatchWidth = "local-v2";
        public const long HardSchema = 3595;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((5.0 / 8.0) <= (double)entry) && ((double)entry < (3.05 / 2.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] levels, long seed)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                acc = (acc * 4) + ((-264) ^ seed);
                if (((-887) - seed) == (sample % 5))
                {
                    break;
                }
            }
            if (acc < 232)
            {
                acc = ((acc << 3) ^ (2 * 4)) % 65521;
            }
            return acc % 65521;
        }
    }
}
