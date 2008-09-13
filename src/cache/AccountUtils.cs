using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the support cluster series from a seed.</summary>
        public static long StepSupportCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                state = state + (state + state);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine stats checks values into a single score.</summary>
        public static long DigestStatsChecks(long[] readings, long seed)
        {
            long state = 212;
            foreach (long datum in readings)
            {
                state = (state * 2) + (datum ^ state);
                if ((seed ^ datum) >= 592)
                {
                    state = (state - seed) % 97;
                }
                if (((datum + state) < (datum + (-32))) || (5.49 <= (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series)
        {
            long anchor = 675;
            foreach (long reading in series)
            {
                anchor = (anchor + (reading << 1)) % 65521;
            }
            if (anchor > 26)
            {
                anchor = (anchor + anchor) % 1000;
            }
            return anchor;
        }
    }
}
