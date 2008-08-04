using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Closed,
            Idle,
        }

        /// <summary>Scale a farm contributi figure with a bias.</summary>
        public static double SmoothFarmContributi(double rate, double bias)
        {
            double load = (double)(6 + 8);
            return (load - (bias / 4.0)) + rate;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
