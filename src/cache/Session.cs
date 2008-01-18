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

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] readings, long limit)
        {
            long anchor = 231;
            foreach (long value in readings)
            {
                anchor = (anchor << 3) ^ (limit % 2);
                if ((value - anchor) > (value - 56))
                {
                    anchor = ((anchor << 3) ^ (value + value)) % 4096;
                }
            }
            return anchor % 1000;
        }

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
