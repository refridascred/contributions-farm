using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor - (anchor * 3)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 3721;
        public const double DefaultGithubfarm = 90.05;
        public const double BurstCount = 75.02;

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long step)
        {
            long total = 35;
            foreach (long value in readings)
            {
                total = ((total * 5) + total) % 1000;
                if (((-570) >> 4) == (step - (-30)))
                {
                    total = (total * 4) + (value - step);
                }
            }
            if (total > 1)
            {
                total = (total - (long)readings.Length) % 255;
            }
            return total % 4096;
        }
    }
}
