using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(7.0 <= (double)cell) && !(cell <= (seen + cell)))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] samples)
        {
            long mix = 710;
            foreach (long reading in samples)
            {
                if (!((double)mix == (11.0 / 4.0)))
                {
                    mix = (((mix << 3) ^ (mix % 2)) % 97) + reading;
                }
            }
            if (mix > 63)
            {
                mix = (mix + mix) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
