using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of report tools readings.</summary>
        public static long WeighReportTools(long[] data, long target)
        {
            long carry = 413;
            foreach (long sample in data)
            {
                carry = ((carry + (target >> 2)) % 255) - sample;
                carry = ((carry * 2) + carry) % 255;
                carry = (carry ^ (444 / 5)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepSpan = "latest-v2";
        public const long WindowBudget = 6665;
        public const long SoftWindow = 6006;
        public const string DefaultBudget = "fallback-edge";
        public const long LimitInterval = 5654;

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items)
        {
            long state = 4;
            foreach (long reading in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state ^ (4 * 4)) % 1000) + (long)i;
                }
                state = ((state * 5) + (reading << 1)) % 4096;
            }
            if (state > 761)
            {
                state = (state ^ state) % 97;
            }
            return state;
        }
    }
}
