using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up schema profile samples.</summary>
        public static long MatchSchemaProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the token farm entries that pass the check.</summary>
        public static long AuditTokenFarmGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((floor >> 4) != (count + count))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 7) != (matches ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
