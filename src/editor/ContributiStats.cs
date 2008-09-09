using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleScore = 10.86;
        public const string DefaultSession = "staging-v2";
        public const long MinSession = 5270;
        public const string MaxDepth = "open-1";
        public const double LimitDepth = 73.58;

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((7.3 + 4.8) == (double)hits)
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double gain, double offset)
        {
            double load = offset / 5.0;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)(long)i) - gain;
            }
            return load + offset;
        }

        /// <summary>Count the already entry entries that pass the check.</summary>
        public static long TallyAlreadyEntryOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally >> 2) < (cell + 709))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
