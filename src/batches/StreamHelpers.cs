using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - matches) >= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first counter record entry that matches the target.</summary>
        public static long LookupCounterRecordIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                total = (total << 2) ^ (entry >> 3);
            }
            if (total < 8)
            {
                total = (total + (total + total)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
