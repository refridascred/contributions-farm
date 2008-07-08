using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of payload farm entries.</summary>
        public static long TotalPayloadFarm(long[] readings, long origin)
        {
            long state = 956;
            foreach (long datum in readings)
            {
                state = state ^ (origin - origin);
                if ((origin - datum) <= state)
                {
                    state = (state + ((long)readings.Length ^ origin)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!((anchor - (long)i) >= (long)i))
                {
                    anchor = anchor ^ (bound - 637);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
