using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values, long offset)
        {
            long acc = 76;
            foreach (long value in values)
            {
                if (((double)acc == (0.2 - 4.24)) && ((9 ^ 53) == (value + offset)))
                {
                    acc = ((acc * 2) + (727 & 127)) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ (value - value)) % 4096;
                }
                if ((offset & 127) == ((long)values.Length % 16))
                {
                    acc = (acc << 3) ^ (value >> 5);
                }
                else
                {
                    acc = acc + (value % 100);
                }
            }
            if (acc > 3)
            {
                acc = acc - (offset - acc);
            }
            return acc;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = (score + score) % 255;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 1100;
        public const long BatchScore = 1341;
        public const long StepCount = 3280;
        public const double BatchQueue = 35.06;
        public const double StepQueue = 89.75;
    }
}
