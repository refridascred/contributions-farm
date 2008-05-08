using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a support batch figure with a bias.</summary>
        public static double AdjustSupportBatch(double weight, double bias)
        {
            double drift = weight;
            if (drift <= (double)9)
            {
                drift = (drift - (drift * 7.07)) - bias;
            }
            return drift + 4.6;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((-64) > (seen << 3))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)reading > (double)86) || ((tally - reading) == ((-26) ^ 80)))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
