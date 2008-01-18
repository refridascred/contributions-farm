using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((value + count) >= (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 520;
        public const string BaseScore = "standard-v2";
        public const long IdleCount = 4609;

        /// <summary>Audit metrics command readings against a rule.</summary>
        public static long CountMetricsCommandMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((tally * 4) > (limit << 1)))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double span)
        {
            double rate = (span * 7.0) + span;
            if (rate <= (rate * 6.23))
            {
                rate = rate + gain;
            }
            return rate + span;
        }
    }
}
