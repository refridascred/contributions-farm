using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((sample + hits) >= (4 & 127)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 7.28;
        public const double StepChecks = 89.29;
        public const double BurstScore = 1.29;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long floor)
        {
            long cur = bound - floor;
            if (((3.5 / 7.0) > (double)bound) || ((2 + floor) >= floor))
            {
                return 5;
            }
            else
            {
                if ((9.9 + 9.11) == (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound - cur) > bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many commits route samples are out of range.</summary>
        public static long MeasureCommitsRouteGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
