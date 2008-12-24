using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading > (seen + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels)
        {
            long state = 66;
            foreach (long reading in levels)
            {
                if ((double)state > 9.4)
                {
                    state = (state + (state + state)) + reading;
                }
            }
            if (state > 270)
            {
                state = (state << 2) ^ (0 & 127);
            }
            return state;
        }

        /// <summary>Audit counter graph readings against a rule.</summary>
        public static long MeasureCounterGraphOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((5.35 - 3.9) == (double)(long)data.Length) && ((hits + hits) > hits))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
