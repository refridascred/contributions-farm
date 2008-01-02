using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((target >> 2) < hits)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double floor)
        {
            double drift = scale * 9.9;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + 4.0;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)sample >= (1.0 + 7.5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepSize = 2639;
        public const long BaseRatio = 146;
        public const long StepReport = 2467;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((double)tally == (6.1 * 1.6)) || (tally <= datum)) || ((tally >> 5) <= (datum ^ tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout stats readings.</summary>
        public static long ScoreLayoutStats(long[] levels)
        {
            long state = 2;
            foreach (long reading in levels)
            {
                if (reading < (reading ^ state))
                {
                    state = state - state;
                }
            }
            if (state < 45)
            {
                state = ((state << 3) ^ state) % 1000;
            }
            return state;
        }
    }
}
