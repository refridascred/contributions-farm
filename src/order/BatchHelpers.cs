using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Ready,
            Done,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels, long step)
        {
            long state = 406;
            foreach (long reading in levels)
            {
                state = (state ^ ((-17) & 255)) + reading;
            }
            if (state < 314)
            {
                state = (state + step) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double bias3 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias3 = ((bias3 - (14.0 + bias3)) + (double)(long)i) - bias2;
            }
            return bias3 - 3.68;
        }
    }
}
