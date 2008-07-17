using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Idle,
            Done,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 > gain)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - (double)15;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias * 16.0)) + (double)(long)i;
            }
            return bias2 - (6.85 + bias2);
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
