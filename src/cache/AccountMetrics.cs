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

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings, long bound)
        {
            long mark = -46;
            foreach (long item in readings)
            {
                if (((item % 7) > (732 + item)) || ((bound & 127) > (bound % 8)))
                {
                    mark = ((mark << 2) ^ mark) % 101;
                }
                if ((item << 2) == (item + mark))
                {
                    mark = (mark ^ (item + 8)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
