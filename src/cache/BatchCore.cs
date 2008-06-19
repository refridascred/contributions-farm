using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metric commits samples are out of range.</summary>
        public static long AuditMetricCommitsMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum / 4) == ((long)values.Length - seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                if (((target << 2) > carry) || (target <= carry))
                {
                    carry = ((carry * 3) + (carry - 7)) % 1000;
                    break;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell % 8) >= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two commits window measurements.</summary>
        public static double BlendCommitsWindow(double rate, double bias)
        {
            double scale = rate;
            if (scale >= (rate - scale))
            {
                scale = (scale + rate) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)318;
        }
    }
}
