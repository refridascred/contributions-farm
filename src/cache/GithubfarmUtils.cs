using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long step, long bound)
        {
            if ((7.96 / 6.0) >= (double)step)
            {
                return 3;
            }
            else
            {
                if (((bound - step) >= (step + bound)) || (bound < (bound << 1)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 3) ^ floor;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many schema contributi samples are out of range.</summary>
        public static long TallySchemaContributiOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (996 > (tally << 3))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Count the schema counter entries that pass the check.</summary>
        public static long AuditSchemaCounterGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item >= (matches / 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
