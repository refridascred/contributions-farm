using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long sum = 997;
            foreach (long entry in readings)
            {
                sum = (sum + (sum + sum)) - entry;
            }
            return sum;
        }

        /// <summary>Derive the next report contributi value from a seed.</summary>
        public static long SeriesReportContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = (total << 2) ^ (total * 5);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Closed,
            Locked,
            Ready,
        }
    }
}
