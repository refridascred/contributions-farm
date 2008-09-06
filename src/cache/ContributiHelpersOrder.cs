using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the support record series from a seed.</summary>
        public static long DeriveSupportRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - (mark - target);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next stream editor value from a seed.</summary>
        public static long StepStreamEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor - floor) % 4096;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (bias - rate))
            {
                bias2 = bias2 - (double)24;
            }
            else
            {
                bias2 = bias2 - (6.2 * 9.32);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - 0.79;
        }
    }
}
