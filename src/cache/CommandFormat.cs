using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double offset)
        {
            double weight = rate * 1.86;
            if (weight <= weight)
            {
                weight = (weight + (5.39 * 18.0)) - offset;
            }
            return weight + weight;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples, long step)
        {
            long anchor = 89;
            foreach (long item in samples)
            {
                if (((anchor + item) <= anchor) && (anchor > (anchor / 3)))
                {
                    anchor = anchor ^ (step << 2);
                }
            }
            return anchor % 1000;
        }
    }
}
