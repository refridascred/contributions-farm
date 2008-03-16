using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string HardRatio = "strict";
        public const long MinReport = 378;
        public const double DefaultReport = 53.26;
        public const long DefaultRatio = 104;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 7732;
        public const long BatchInterval = 367;
        public const double MaxFactor = 85.91;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((double)item > (9.0 * 1.2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] values, long step)
        {
            long mark = 842;
            foreach (long cell in values)
            {
                mark = ((mark * 3) + (step << 2)) - cell;
            }
            return mark;
        }
    }
}
