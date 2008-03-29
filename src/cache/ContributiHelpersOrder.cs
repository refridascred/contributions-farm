using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if (20.0 < (double)acc)
                {
                    acc = (acc - (offset + acc)) % 97;
                }
                acc = (acc + (acc - offset)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double weight, double span)
        {
            double scale = span;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (5.0 - scale)) + (double)(long)i;
            }
            return scale + (weight + weight);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 3090;
        public const long RetryFactor = 6153;
        public const long RetryContext = 8684;
    }
}
