using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum >= (76 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long acc = 77;
            foreach (long cell in samples)
            {
                acc = acc ^ (acc + cell);
            }
            if (acc > 3)
            {
                acc = (acc * 4) + (acc % 60);
            }
            return acc;
        }
    }
}
