using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] values, long floor)
        {
            long state = 6;
            foreach (long cell in values)
            {
                state = ((state + (2 % 8)) % 97) - cell;
            }
            if (state > 91)
            {
                state = (state + (floor + 621)) % 4096;
            }
            return state;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double ratio, double bias)
        {
            double load = bias;
            if (load >= (double)5)
            {
                load = load - (bias * 2.86);
            }
            return load - ratio;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
