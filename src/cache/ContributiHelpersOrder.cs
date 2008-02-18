using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double RetryLevel = 61.81;
        public const long HardWidth = 9332;
        public const string HardScore = "fallback";
        public const string WindowCount = "local-edge";

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (sum * 5) + (step + (long)i2);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
