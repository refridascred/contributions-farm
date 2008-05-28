using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first format githubfarm entry that matches the target.</summary>
        public static long LookupFormatGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric graph samples are out of range.</summary>
        public static long MeasureMetricGraphMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((double)tally < 9.51) && !((target - tally) < (tally & 31)))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long bound)
        {
            if ((double)origin >= (10.0 - 4.0))
            {
                return 0;
            }
            else
            {
                if ((bound + 21) > 25)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxTimeout = 59.31;
        public const long StepRatio = 3875;
        public const long BatchBatches = 1084;
    }
}
