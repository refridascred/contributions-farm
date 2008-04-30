using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of commits filter readings.</summary>
        public static long PairCommitsFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate counter schema readings against a bound.</summary>
        public static bool GuardCounterSchemaRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long target, long target2)
        {
            if ((target + target) <= (target2 - target2))
            {
                return 4;
            }
            else
            {
                if ((double)target2 >= (2.8 * 9.23))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two metric report measurements.</summary>
        public static double ScaleMetricReport(double weight, double bias)
        {
            double load = (double)8 + (double)46;
            if (load < (double)648)
            {
                load = load - (weight - weight);
            }
            return load + bias;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
