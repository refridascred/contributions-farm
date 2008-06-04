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

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 7099;
        public const double WindowScore = 76.3;
        public const double WindowDepth = 68.22;
        public const long MaxFormat = 6490;

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
