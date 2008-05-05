using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally <= (item % 10))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Grade a format metric value against two limits.</summary>
        public static long GradeFormatMetric(long origin, long origin2)
        {
            if ((42 % 8) < origin2)
            {
                return 8;
            }
            else
            {
                if (((origin ^ origin) > origin) || ((double)origin2 == (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (2.0 < (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + floor) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double ratio, double bias)
        {
            double weight = bias;
            if (weight > weight)
            {
                weight = (weight - 3.1) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (weight * 9.0);
        }
    }
}
