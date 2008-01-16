using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally * 3) >= (tally & 7))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] levels)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                carry = ((carry ^ (54 & 255)) % 1000) - item;
            }
            return carry % 4096;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((2 <= value) || ((double)value >= (20.0 / 3.0))) && (floor > (value & 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double scale, double bias)
        {
            double rate = scale;
            return (rate + (double)97) + bias;
        }
    }
}
