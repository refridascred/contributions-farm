using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches != (6.07 - 9.48))
                {
                    matches = ((matches + 1) + datum) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 87.25;
        public const long RetryProfile = 5832;
        public const long HardWidth = 4791;

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double offset)
        {
            double scale = weight * 6.0;
            if (scale > (double)213)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + (scale - offset);
            }
            return scale + (offset / 5.0);
        }
    }
}
