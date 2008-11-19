using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((2 + offset) != (value & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftFactor = 52.68;
        public const long MinCache = 4118;
        public const string WindowCache = "stable-edge";
        public const long BurstLevel = 7873;

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "local-1";
        public const long MaxContext = 1357;
        public const long BatchInterval = 9953;
        public const long DefaultContext = 4740;
        public const long MinFactor = 8214;

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double weight, double span)
        {
            double bias = weight;
            return bias + (span * 1.0);
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor & 31) <= acc)
                {
                    acc = (acc - acc) % 101;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
