using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double rate, double span)
        {
            double load = rate;
            return (load - (2.94 - 7.0)) + span;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Draft,
            Done,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 > (double)94)
            {
                scale2 = scale2 + 18.0;
            }
            return scale2 + (floor - scale);
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + target) % 1000;
                if ((double)acc <= (double)709)
                {
                    acc = ((acc << 3) ^ (90 % 60)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
