using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                long cur = (state * 5) << 3;
                state = ((state << 2) ^ (step - 393)) % 255;
                if (((step - 73) >= ((long)i % 7)) && (state >= cur))
                {
                    state = state + (cur << 3);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit support schema readings against a rule.</summary>
        public static long CountSupportSchemaOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)step <= (2.29 + 0.7))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
