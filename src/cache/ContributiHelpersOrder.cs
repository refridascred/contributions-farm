using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                long edge = (-137) + (mark + mark);
                if ((edge < seed) || ((seed ^ (long)i) <= (188 * 5)))
                {
                    edge = (edge * 2) + mark;
                    edge = edge - (seed + edge);
                    break;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two payload tools measurements.</summary>
        public static double SmoothPayloadTools(double weight, double span)
        {
            double mean = weight - span;
            if (mean < mean)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + span) - (double)(long)i;
            }
            return mean + 7.42;
        }
    }
}
