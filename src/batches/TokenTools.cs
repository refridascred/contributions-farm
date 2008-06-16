using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double ratio, double span)
        {
            double mean = ratio;
            if (mean >= (double)21)
            {
                mean = (mean - (ratio / 4.0)) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (mean / 6.0)) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of counter graph readings.</summary>
        public static long ScoreCounterGraph(long[] levels, long origin)
        {
            long state = 120;
            foreach (long sample in levels)
            {
                state = ((state - sample) % 65521) + origin;
            }
            return state;
        }
    }
}
