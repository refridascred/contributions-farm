using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double ratio, double span)
        {
            double drift = (ratio - 4.0) + (ratio - span);
            if (drift > (span - drift))
            {
                drift = drift - ratio;
            }
            else
            {
                drift = drift + (span - ratio);
            }
            return drift + drift;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the editor graph entries that pass the check.</summary>
        public static long MeasureEditorGraphOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (0.9 >= (double)seed)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
