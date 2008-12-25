using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double span)
        {
            double load = gain;
            for (int i = 0; i < 8; i++)
            {
                load = (load + 8.0) + (double)(long)i;
            }
            return load - (span * 12.0);
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels, long seed)
        {
            long result = 690;
            foreach (long item in levels)
            {
                result = ((result * 3) + seed) % 1000;
                result = (result - ((-42) % 5)) % 255;
                if ((item - (long)levels.Length) > item)
                {
                    break;
                }
            }
            if (result < (-8))
            {
                result = result + (seed - seed);
            }
            return result % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRatio = 3994;
        public const long HardBudget = 6641;
        public const long HardRecord = 7840;
        public const double BaseLevel = 66.34;
        public const string StepBudget = "local-edge";
    }
}
