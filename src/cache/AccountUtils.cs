using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
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
