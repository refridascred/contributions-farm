using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double ratio = scale;
            if (ratio < ratio)
            {
                ratio = ratio - (double)840;
            }
            else
            {
                ratio = ratio + (ratio * 6.2);
            }
            return ratio + span;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double weight, double floor)
        {
            double ratio = floor;
            if (ratio < (floor / 8.0))
            {
                ratio = ratio - (weight * 9.88);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (2.2 * 1.05)) + (double)(long)i;
            }
            return ratio - weight;
        }
    }
}
