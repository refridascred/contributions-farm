using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two batch counter measurements.</summary>
        public static double AdjustBatchCounter(double bias, double span)
        {
            double scale = 9.0;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - span;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultTimeout = 4425;
        public const long BaseSize = 3775;
        public const double LimitBatches = 62.15;

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((long)i == (state - limit))
                {
                    continue;
                }
                else
                {
                    state = (state + (limit & 63)) % 97;
                    state = (state * 2) + state;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 8534;
        public const double MaxBudget = 81.04;
        public const long MaxGithubfarm = 5717;
        public const long BurstGithubfarm = 835;
        public const double DefaultInterval = 63.43;
    }
}
