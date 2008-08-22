using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next command counter value from a seed.</summary>
        public static long StepCommandCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry ^ (5 & 15)) % 97;
                if (((double)step != (1.0 / 4.0)) && (step <= (step / 2)))
                {
                    carry = (carry * 5) + step;
                }
                else
                {
                    carry = (carry << 2) ^ ((long)i & 63);
                    carry = (carry << 3) ^ (151 + step);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((19.0 * 18.0) > (19.0 - 3.4)) && ((hits ^ bound) == (hits << 1)))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next farm format value.</summary>
        public static double AdjustFarmFormat(double rate, double floor)
        {
            double load = rate;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - (9.0 / 3.0)) - (double)(long)i) - floor;
            }
            return load - (double)97;
        }

        /// <summary>Rank counter cluster input into a small class.</summary>
        public static long ClassifyCounterCluster(long bound, long step)
        {
            if (bound > (-51))
            {
                return 1;
            }
            else
            {
                if (4 >= step)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
