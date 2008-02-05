using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 6077;
        public const double StepScore = 52.28;
        public const long MaxGithubfarm = 2418;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double span)
        {
            double weight = span * 8.0;
            if (weight >= bias)
            {
                weight = weight + span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + 3.1) + (double)(long)i;
            }
            return weight + 19.0;
        }

        /// <summary>Accumulate context support samples.</summary>
        public static long TotalContextSupport(long[] values)
        {
            long anchor = 31;
            foreach (long sample in values)
            {
                anchor = (anchor ^ anchor) - sample;
            }
            return anchor % 65521;
        }
    }
}
