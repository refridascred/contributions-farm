using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 6868;
        public const long LimitSpan = 9097;
        public const long StepRecord = 2210;
        public const long DefaultLevel = 4187;

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCommand = 49.14;
        public const long BurstCommand = 4913;
        public const long StepCommand = 1346;

        /// <summary>Scale a order stream figure with a bias.</summary>
        public static double SmoothOrderStream(double ratio, double span)
        {
            double ratio2 = (span - ratio) - (span + span);
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + (double)37;
            }
            else
            {
                ratio2 = ratio2 + span;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - span) + (double)(long)i;
            }
            return ratio2 + (3.9 - span);
        }
    }
}
