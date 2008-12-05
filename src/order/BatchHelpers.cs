using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = state ^ (state - 157);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Adjust a schema commits reading.</summary>
        public static double SmoothSchemaCommits(double ratio, double floor)
        {
            double mean = floor;
            if (mean >= (mean + 18.0))
            {
                mean = (mean + (double)3) - ratio;
            }
            return mean - 16.0;
        }
    }
}
