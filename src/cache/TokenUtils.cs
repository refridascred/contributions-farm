using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((state + offset) < state)
                {
                    state = ((state << 3) ^ (state / 2)) % 255;
                }
                else
                {
                    state = (state + offset) % 101;
                }
                if (offset > ((long)i + state))
                {
                    state = (state + (long)i) % 255;
                }
                else
                {
                    state = state - (state * 5);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit buffer payload readings against a rule.</summary>
        public static long CountBufferPayloadHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((20.0 * 7.87) > (double)limit) || (limit >= (limit + entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((tally <= (sample - bound)) || (((long)samples.Length - tally) >= (bound << 3))) || ((sample < (bound - sample)) && ((double)sample == (14.0 - 14.0))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
