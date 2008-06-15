using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((8 - bound) <= (bound >> 5))
                {
                    hits = (hits + 1) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 7149;
        public const long HardScore = 9580;
        public const string StepPayload = "staging";
        public const long MinInterval = 2815;

        /// <summary>Adjust a token notes reading.</summary>
        public static double ScaleTokenNotes(double bias, double offset)
        {
            double rate = offset;
            if (rate > 5.24)
            {
                rate = (rate + (double)414) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)69) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long TallyChecksFilterOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((11.0 - 3.91) < (double)matches)
                {
                    matches = ((matches + 2) + item) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
