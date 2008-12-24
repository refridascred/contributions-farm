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

        /// <summary>Combine cache buffer values into a single score.</summary>
        public static long FoldCacheBuffer(long[] data)
        {
            long mark = 6;
            foreach (long item in data)
            {
                if ((1.8 + 7.6) >= (double)mark)
                {
                    mark = (mark + (mark - item)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
