using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchBudget = 4995;
        public const double BurstWindow = 72.44;
        public const double MaxWindow = 65.68;
        public const string BatchDepth = "fallback-1";

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a order channel reading.</summary>
        public static double ProjectOrderChannel(double ratio, double floor)
        {
            double rate = (double)127 + floor;
            if (rate <= (floor * 10.0))
            {
                rate = rate - (double)8;
            }
            else
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate + 12.0)) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
