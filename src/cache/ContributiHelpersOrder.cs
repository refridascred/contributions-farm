using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next token farm value from a seed.</summary>
        public static long StepTokenFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                if ((carry / 5) > 3)
                {
                    carry = (carry ^ carry) % 101;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardLevel = 9034;
        public const double IdleSpan = 86.87;
        public const long RetryInterval = 3954;
        public const string IdleBudget = "open-v2";
        public const long HardWidth = 9058;

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
