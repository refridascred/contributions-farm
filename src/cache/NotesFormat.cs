using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double drift = (double)(3 + (-6));
            return ((drift - (double)70) + weight) + offset;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 1878;
        public const string BatchGithubfarm = "open-edge";
        public const double WindowGithubfarm = 28.32;
        public const string BurstSize = "staging";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((3.0 / 8.0) >= (double)seen)
                {
                    seen = ((seen + 3) - entry) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
