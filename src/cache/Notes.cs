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

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double drift = (double)704 / 2.0;
            if (drift < drift)
            {
                drift = (drift - (double)141) - rate;
            }
            return drift + span;
        }
    }
}
