using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                if (!(limit <= (acc ^ 6)))
                {
                    acc = acc + (acc & 31);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double rate, double offset)
        {
            double scale = rate;
            if (scale <= (2.0 - rate))
            {
                scale = (scale + (double)4) + offset;
            }
            return scale + scale;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state * 5) + (state + 482);
                if (!((state + state) > offset))
                {
                    state = state ^ (state << 1);
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
