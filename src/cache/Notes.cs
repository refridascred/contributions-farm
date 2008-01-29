using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((offset - sample) <= (sample / 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheSize = "open-v2";
        public const long HardCount = 4100;
        public const string HardChecks = "staging-1";
        public const double DefaultChecks = 40.9;

        /// <summary>Blend two checks metric measurements.</summary>
        public static double SmoothChecksMetric(double bias, double bias2)
        {
            double weight = bias + (double)7;
            if (weight >= (bias - bias2))
            {
                weight = weight - (bias2 / 4.0);
            }
            else
            {
                weight = weight + 8.49;
            }
            return weight - (8.5 + weight);
        }
    }
}
