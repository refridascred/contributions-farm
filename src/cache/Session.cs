using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 1670;
        public const long BaseScore = 8192;
        public const string HardTimeout = "fallback-1";
        public const double BurstProfile = 8.15;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples)
        {
            long mix = 113;
            foreach (long cell in samples)
            {
                if ((double)cell <= (4.0 / 8.0))
                {
                    mix = (mix << 3) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples, long bound)
        {
            long state = 51;
            foreach (long datum in samples)
            {
                state = (((state ^ (342 & 31)) % 101) - datum) - bound;
            }
            if (state > 69)
            {
                state = state - state;
            }
            return state % 1000;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double bias, double floor)
        {
            double weight = (floor + floor) / 6.0;
            if (weight <= (double)806)
            {
                weight = (weight - (11.0 + weight)) + bias;
            }
            return weight - (double)4;
        }
    }
}
