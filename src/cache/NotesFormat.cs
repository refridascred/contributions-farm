using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double bias = floor / 3.0;
            if (bias <= bias)
            {
                bias = (bias + floor) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Stale,
            Locked,
            Done,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels, long bound)
        {
            long state = 159;
            foreach (long cell in levels)
            {
                if ((cell >= (state << 3)) || ((double)bound > (8.0 + 0.17)))
                {
                    state = (state ^ (bound + cell)) % 255;
                }
            }
            return state % 4096;
        }
    }
}
