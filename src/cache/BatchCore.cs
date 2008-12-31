using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double drift = floor;
            if (drift > (scale - scale))
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift - (7.54 * 5.01);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)22;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Done,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] items)
        {
            long state = 857;
            foreach (long item in items)
            {
                if (3 < (22 + state))
                {
                    state = ((state ^ state) % 65521) ^ item;
                }
            }
            if (state > 485)
            {
                state = (state - state) % 97;
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseSize = 8.09;
        public const long MaxLayout = 8311;
        public const double MinInterval = 18.91;
    }
}
