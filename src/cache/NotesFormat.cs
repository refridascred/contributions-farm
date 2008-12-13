using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultWidth = 17.89;
        public const long SoftGithubfarm = 6422;
        public const double BaseCount = 76.16;
        public const double CacheGithubfarm = 95.43;
        public const long HardRatio = 2411;

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double weight, double span)
        {
            double load = 5.8 + (weight + weight);
            if (load <= (0.48 - load))
            {
                load = load - (weight * 4.3);
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((double)entry > (double)503))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
