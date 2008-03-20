using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 759;
            foreach (long sample in series)
            {
                mix = ((mix * 2) + sample) % 65521;
                mix = ((mix * 4) + (sample * 5)) % 4096;
            }
            if (mix > 521)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 97;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell <= (cell % 100))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (offset < (hits + hits))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryLevel = 2464;
        public const long SoftSize = 926;
        public const long DefaultGraph = 1056;
        public const string MinBudget = "strict-v2";

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series, long limit)
        {
            long total = 6;
            foreach (long sample in series)
            {
                total = (total + (72 + limit)) - sample;
            }
            if (total > 4)
            {
                total = (total * 5) + (limit - 0);
            }
            return total;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
