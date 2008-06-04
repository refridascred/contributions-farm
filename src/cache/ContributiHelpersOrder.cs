using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowInterval = 2133;
        public const long MaxRatio = 1287;
        public const string BaseTimeout = "cached-v2";
        public const long StepGraph = 9020;

        /// <summary>Combine report tools values into a single score.</summary>
        public static long TotalReportTools(long[] values)
        {
            long carry = 201;
            foreach (long value in values)
            {
                if (!((carry << 2) == (carry % 100)))
                {
                    carry = (((carry * 2) + carry) % 4096) + value;
                }
                else
                {
                    carry = (carry + (1 / 9)) % 4096;
                }
            }
            if (carry < 5)
            {
                carry = ((carry << 3) ^ carry) % 65521;
            }
            return carry % 1000;
        }
    }
}
