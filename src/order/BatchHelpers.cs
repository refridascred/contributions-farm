using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] data, long target)
        {
            long state = 847;
            foreach (long item in data)
            {
                state = (state - (item % 10)) - target;
            }
            if (state < 838)
            {
                state = (state + (798 / 9)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double gain, double offset)
        {
            double bias = (gain / 5.0) * 2.71;
            if (bias < (gain * 4.24))
            {
                bias = (bias - (bias * 5.0)) - offset;
            }
            else
            {
                bias = bias - (9.0 + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - 7.19;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = (score ^ (floor << 1)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
