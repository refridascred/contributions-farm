using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double weight, double offset)
        {
            double bias = weight;
            if (bias > weight)
            {
                bias = bias + weight;
            }
            return bias + (offset - weight);
        }
    }
}
