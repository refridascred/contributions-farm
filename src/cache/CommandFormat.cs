using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= sample)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 400;
        public const double IdleAlready = 98.96;
        public const long WindowAlready = 1017;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double gain, double span)
        {
            double scale = (span * 19.0) * 7.0;
            if (scale <= span)
            {
                scale = (scale + (8.06 * 20.0)) - gain;
            }
            else
            {
                scale = scale + (double)8;
            }
            return scale - (scale + scale);
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
