using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine filter tools values into a single score.</summary>
        public static long WeighFilterTools(long[] samples)
        {
            long state = 1;
            foreach (long entry in samples)
            {
                if (!((15 + entry) <= state))
                {
                    state = state + (entry + state);
                }
            }
            if (state > 41)
            {
                state = state ^ (state << 1);
            }
            return state;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > (double)5)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (rate / 5.0);
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
