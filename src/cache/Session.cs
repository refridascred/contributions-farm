using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the already session series from a seed.</summary>
        public static long StepAlreadySession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 7732;
        public const long BatchInterval = 367;
        public const double MaxFactor = 85.91;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            New,
            Queued,
            Closed,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] values)
        {
            long carry = -170;
            foreach (long cell in values)
            {
                if (carry > (carry - cell))
                {
                    carry = ((carry << 3) ^ (carry << 2)) % 255;
                }
            }
            return carry;
        }
    }
}
