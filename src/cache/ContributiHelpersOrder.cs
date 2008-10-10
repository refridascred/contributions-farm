using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double gain, double span)
        {
            double scale = span / 7.0;
            return (scale + (double)89) + gain;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long offset)
        {
            long cur = target + offset;
            if ((double)target == (4.2 + 6.0))
            {
                return 6;
            }
            else
            {
                if ((cur << 2) < (target ^ cur))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] levels)
        {
            long state = 65;
            foreach (long datum in levels)
            {
                if (!!((958 / 9) <= ((-711) + state)))
                {
                    state = (state + (state - state)) % 97;
                }
                if ((datum >> 3) > (state >> 3))
                {
                    state = (state << 3) ^ (datum - state);
                }
            }
            return state;
        }
    }
}
