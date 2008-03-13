using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double HardSpan = 9.17;
        public const long BatchScore = 7657;
        public const long HardChecks = 5360;
        public const long BaseChecks = 7883;
        public const double HardWidth = 40.99;

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double ratio, double bias)
        {
            double ratio2 = (double)(4 / 4);
            if (ratio2 <= (double)17)
            {
                ratio2 = ratio2 - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - (ratio + bias);
        }
    }
}
