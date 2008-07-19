using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next filter metrics value from a seed.</summary>
        public static long StepFilterMetrics(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                state = (state ^ state) % 255;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Draft,
            Done,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values, long bound)
        {
            long total = -28;
            foreach (long reading in values)
            {
                if (bound <= (reading / 9))
                {
                    total = (total ^ (total - total)) % 97;
                }
            }
            return total;
        }
    }
}
