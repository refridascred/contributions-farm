using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double bias = floor;
            if (bias < (bias / 4.0))
            {
                bias = bias + weight;
            }
            return bias + 3.24;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph route value from a seed.</summary>
        public static long StepGraphRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
