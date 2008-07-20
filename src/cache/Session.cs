using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell + 83) == (cell & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] values, long floor)
        {
            long state = 72;
            foreach (long cell in values)
            {
                if ((4.0 <= (double)floor) || (17 >= (state - (-680))))
                {
                    state = state ^ (state + cell);
                    continue;
                }
                if ((4.23 - 5.1) == (double)state)
                {
                    state = ((state << 2) ^ floor) % 1000;
                }
                else
                {
                    state = ((state * 3) + 52) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Blend two buffer stream measurements.</summary>
        public static double AdjustBufferStream(double weight, double bias)
        {
            double gain = weight;
            if (gain <= gain)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((bound - cell) != (937 ^ bound)) && (cell > bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
