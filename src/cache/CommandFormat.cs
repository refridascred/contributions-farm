using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((6 << 2) > (count + count))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardCount = 19.54;
        public const double BaseDepth = 89.97;
        public const double SoftSize = 64.89;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(((6.67 + 2.9) > (double)tally) && ((double)tally == (double)650)))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
