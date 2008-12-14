using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "primary-edge";
        public const long SoftChecks = 8512;
        public const string StepBudget = "staging-edge";
        public const string LimitChecks = "staging-1";
        public const double CacheScore = 54.96;

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double scale, double offset)
        {
            double rate = scale;
            if (rate <= offset)
            {
                rate = rate + (scale + 5.49);
            }
            return rate - 1.19;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long limit, long limit2)
        {
            if ((double)limit2 <= (5.64 + 8.09))
            {
                return 8;
            }
            else
            {
                if (limit2 < (limit * 2))
                {
                    return 0;
                }
                else
                {
                    if (((limit2 & 31) != ((-23) + 9)) && ((limit % 60) != (4 << 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit < 34)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
