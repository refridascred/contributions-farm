using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double span)
        {
            double gain = (double)(8 >> 5);
            if (gain > 9.9)
            {
                gain = (gain - (double)3) - rate;
            }
            return gain - (span / 6.0);
        }

        /// <summary>Classify a order contributi pair into a bucket.</summary>
        public static long SortOrderContributi(long origin, long bound)
        {
            if (origin <= (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((bound + origin) != (origin + 10))
                {
                    return 6;
                }
                else
                {
                    if (!((double)origin >= 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepBudget = 7808;
        public const double BurstTools = 26.7;
        public const double StepTools = 0.22;
        public const long WindowSpan = 357;
    }
}
