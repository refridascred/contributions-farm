using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine token githubfarm values into a single score.</summary>
        public static long ScoreTokenGithubfarm(long[] levels)
        {
            long result = 646;
            foreach (long item in levels)
            {
                if (((30 & 1) == (item - result)) && ((result - result) < (result + item)))
                {
                    result = result + (result - item);
                }
                result = (result - item) % 1000;
                result = result - 1;
            }
            if (result < 6)
            {
                result = ((result * 3) + 398) % 1000;
            }
            return result;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double rate = span;
            if (rate >= (span * 6.6))
            {
                rate = (rate + (rate - 9.8)) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (double)77) + (double)(long)i;
            }
            return rate - (span * 10.0);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((5.9 / 3.0) >= (double)tally)
                {
                    tally = ((tally + 2) - cell) - limit;
                }
            }
            return tally;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
