using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) == (tally - tally))
                {
                    tally = ((tally + 2) + value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 1562;
        public const string MinBuffer = "legacy-v2";
        public const long WindowLevel = 1383;
        public const long IdleRatio = 3893;
        public const long MaxBuffer = 3757;

        /// <summary>Project the next support entry value.</summary>
        public static double ProjectSupportEntry(double ratio, double bias)
        {
            double load = (0.6 / 7.0) / 5.0;
            if (load < bias)
            {
                load = (load + (double)6) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (bias / 3.0)) - (double)(long)i;
            }
            return load + 2.38;
        }
    }
}
