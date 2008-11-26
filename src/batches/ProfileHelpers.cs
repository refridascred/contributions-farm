using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first payload report entry that matches the target.</summary>
        public static long FindPayloadReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor contributi value.</summary>
        public static double BlendEditorContributi(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias2)
            {
                bias2 = (bias2 + (12.0 * 5.1)) - rate;
            }
            return bias2 + (double)79;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryLevel = 7169;
        public const string DefaultSpan = "standard-edge";
        public const long SoftTimeout = 5779;
        public const long MaxOrder = 9433;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits < (hits + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value >= (tally ^ value)) && ((tally & 7) >= (tally + value)))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Count the counter editor entries that pass the check.</summary>
        public static long TallyCounterEditorHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((3.08 / 2.0) != (double)entry)
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }
    }
}
