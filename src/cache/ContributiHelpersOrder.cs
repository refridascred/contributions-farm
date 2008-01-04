using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a profile contributi reading.</summary>
        public static double AdjustProfileContributi(double weight, double span)
        {
            double gain = (double)(-45) + (weight + weight);
            if (gain <= (gain * 3.0))
            {
                gain = (gain + (gain * 2.0)) - span;
            }
            return gain + (double)771;
        }
    }
}
