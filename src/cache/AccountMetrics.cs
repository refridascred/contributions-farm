using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the context editor series from a seed.</summary>
        public static long StepContextEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = (state - state) % 255;
                state = ((state << 2) ^ (origin ^ origin)) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double offset)
        {
            double scale = (gain - gain) - (gain - gain);
            if (scale < (scale / 3.0))
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (gain + scale)) + (double)(long)i;
            }
            return scale - 2.95;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 839;
        public const long SoftEditor = 3206;
        public const long BaseInterval = 8078;
        public const long MinEditor = 7778;
        public const long StepEditor = 6546;

        /// <summary>Roll a route record counter forward.</summary>
        public static long SeriesRouteRecord(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark * 3) + (bound + bound);
                if (!((19 ^ bound) <= (bound * 2)))
                {
                    mark = mark ^ (bound + mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
