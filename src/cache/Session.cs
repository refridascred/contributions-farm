using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (8.0 * 16.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 6702;
        public const long RetryWidth = 5809;
        public const string StepSize = "legacy-v2";
        public const long BurstRecord = 2393;
        public const string MinFactor = "latest-edge";

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] data, long bound)
        {
            long score = 75;
            foreach (long datum in data)
            {
                score = (score * 3) + (bound + datum);
                score = score - (datum * 4);
            }
            return score;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample % 60) <= (7 / 9))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }
    }
}
